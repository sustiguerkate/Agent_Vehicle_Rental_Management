using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalVRM.Models.customerManagement
{
    public class driversLicense 
    {
        public int LicenseID { get; set; }

        public int UserID { get; set; }

        public string LicenseNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string IssuingCountry { get; set; }

        public bool IsExpired => DateTime.Now > ExpiryDate;

        public string LicenseImagePath { get; set; }
    }
}
    

