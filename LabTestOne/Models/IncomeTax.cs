using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestOne.Models
{
    public class IncomeTax : Base
    {
        public string nameOfAsse { get; set; }
        public string nid { get; set; }
        public string utin { get; set; }
        public string tin { get; set; }
        public string circel { get; set; }
        public string taxZone { get; set; }
        public string asseYear { get; set; }
        public bool isResident { get; set; }
        public bool familyStatus { get; set; }
        public string nameOFEmployee { get; set; }
        public string husbandORWife { get; set; }
        public string father { get; set; }
        public string mother { get; set; }
        public string dateOFBirth { get; set; }
        public string presentAddress { get; set; }
        public string prmanentAddress { get; set; }
        public string mobileOffice { get; set; }
        public string residential { get; set; }
        public string vatRegistrationNo { get; set; }
    }
}
