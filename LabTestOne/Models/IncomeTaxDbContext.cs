using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using System.Linq;
using System.Threading.Tasks;
using LabTestOne.Data.Entity;
using LabTestOne.Models;

namespace LabTestOne.Data
{
    public class IncomeTaxDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IncomeTaxDbContext(DbContextOptions<IncomeTaxDbContext> options, IHttpContextAccessor _httpContextAccessor) : base(options)
        {
            this._httpContextAccessor = _httpContextAccessor;
        }
              

        #region Income Tax

        public DbSet<IncomeTax> IncomeTaxes { get; set; }
        
        #endregion
    }
}
