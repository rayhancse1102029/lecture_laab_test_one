using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LabTestOne.Models
{
    public class Base
    {
        public string createdBy { get; set; }
        public string updatedBy { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
