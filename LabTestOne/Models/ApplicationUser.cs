using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LabTestOne.Data.Entity
{
    public class ApplicationUser: IdentityUser
    {

        public int? userTypeId { get; set; }
        //public UserType userType { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string EmpCode { get; set; }

       //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       // public int userId { get; set; }
        public int? userId { get; set; }

        //public int? companyId { get; set; }
        //public Company company { get; set; }

        //public int? vendorOrganizationId { get; set; }
        //public VendorOrganization vendorOrganization { get; set; }

        public DateTime? createdAt { get; set; }

        public string createdBy { get; set; }

        public DateTime? updatedAt { get; set; }

        public string updatedBy { get; set; }

        
        public decimal? MaxAmount { get; set; }
        public bool isActive { get; set; }
        public string org { get; set; }
        //public int? specialBranchUnitId { get; set; }
        //public SpecialBranchUnit specialBranchUnit { get; set; }

        [StringLength(100)]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Citizenship { get; set; }

        public int? NationalIdentityType { get; set; }
        [StringLength(100)]
        public string NationalIdentityNo { get; set; }
        public int? AddressType { get; set; }
        public string AddressDetails { get; set; }

        [StringLength(300)]
        public string ImagePath { get; set; }
        public string otpCode { get; set; }
        public int? isVarified { get; set; }

        [NotMapped]
        public IFormFile formFile { get; set; }

    }
}
