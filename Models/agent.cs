using FinalVRM.Models.customerManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalVRM.Models
{
    public class agent : person
    {
        public driversLicense License { get; set; }


        public agent()
        {
            Role = "agent";
            License = new driversLicense();
        }
    }
}
    

