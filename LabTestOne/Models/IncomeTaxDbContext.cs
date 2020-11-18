using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestOne.Data
{
    public class IncomeTaxDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IncomeTaxDbContext(DbContextOptions<IncomeTaxDbContext> options, IHttpContextAccessor _httpContextAccessor) : base(options)
        {
            this._httpContextAccessor = _httpContextAccessor;
        }

        #region Settings Configs
        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }

        private void AddTimestamps()
        {

            var entities = ChangeTracker.Entries().Where(x => x.Entity is Base && (x.State == EntityState.Added || x.State == EntityState.Modified));

            var currentUsername = !string.IsNullOrEmpty(_httpContextAccessor?.HttpContext?.User?.Identity?.Name)
                ? _httpContextAccessor.HttpContext.User.Identity.Name
                : "Anonymous";

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((Base)entity.Entity).createdAt = DateTime.Now;
                    ((Base)entity.Entity).createdBy = currentUsername;
                }
                else
                {
                    entity.Property("createdAt").IsModified = false;
                    entity.Property("createdBy").IsModified = false;
                    ((Base)entity.Entity).updatedAt = DateTime.Now;
                    ((Base)entity.Entity).updatedBy = currentUsername;
                }

            }
        }
        #endregion

        #region Attachment Comment
        public DbSet<DocumentAttachment> DocumentAttachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        #endregion

        #region Master Data
        public DbSet<AddressType> AddressTypes { get; set; }
        #endregion

        #region User Manager
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<UserTypeGroup> UserTypeGroups { get; set; }
        public DbSet<UserAccessPage> UserAccessPages { get; set; }
        public DbSet<Navbar> Navbars { get; set; }
        public DbSet<MenuBand> MenuBands { get; set; }
        public DbQuery<NavbarViewModel> navbarViewModels { get; set; }
        public DbQuery<UserAccessPageViewModel> userAccessPageViewModels { get; set; }
        public DbQuery<UpdateAspnetUser> updateAspnetUsers { get; set; }
        #endregion

        #region Master Data
        public DbSet<ERPModule> ERPModules { get; set; }
        public DbSet<ERPModuleAssign> ERPModuleAssigns { get; set; }
        public DbSet<ModuleAccessPage> ModuleAccessPages { get; set; }
        public DbSet<DocumentPhotoAttachment> DocumentPhotoAttachments { get; set; }
        public DbQuery<AspNetUsersViewModel> AspNetUsersViewModels { get; set; }
        public DbSet<Address> Addresses { get; set; }        
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Thana> Thanas { get; set; }
        public DbSet<PostOffice> PostOffices { get; set; }
        public DbSet<Resource> Resources { get; set; }       
        public DbSet<AddressCategory> addressCategories { get; set; }

        public DbSet<Company> Companies { get; set; }       
        public DbSet<UserLogHistory> UserLogHistories { get; set; }
        public DbSet<OrganizationType> OrganizationTypes { get; set; }      
        public DbSet<Organization> Organizations { get; set; }      
        public DbSet<StoreType> StoreTypes { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreAssign> StoreAssigns { get; set; }
        public DbQuery<AspNetUsersListViewModel> aspNetUsersViews { get; set; }
        public DbQuery<RoleType> RoleTypes { get; set; }
        public DbQuery<UserBackup> UserBackups { get; set; }


        #region

        public DbSet<TaxYear> taxYears { get; set; }

        #endregion

        #endregion


        #region Income Tax

        public DbSet<TaxPayMaster> TaxPayMasters { get; set; }
        public DbSet<IncomeAssesseeStatement> IncomeAssesseeStatements { get; set; }
        public DbSet<IncomeScheduleDetailsOne> IncomeScheduleDetailsOnes { get; set; }
        public DbSet<IncomeScheduleDetailsTwo> IncomeScheduleDetailsTwos { get; set; }
        public DbSet<IncomeScheduleDetailsThree> IncomeScheduleDetailsThrees { get; set; }
        public DbSet<FurnishedDocument> FurnishedDocuments { get; set; }
        public DbSet<LiabilitiesAssetsStatement> LiabilitiesAssetsStatements { get; set; }
        public DbSet<DirectorShareholding> DirectorShareholdings { get; set; }
        public DbSet<IncomeTaxOrdinance> IncomeTaxOrdinances { get; set; }
        public DbSet<ReturnForm> ReturnForms { get; set; }

        #endregion
    }
}
