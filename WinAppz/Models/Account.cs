using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Account
    {
        [Key]
        public int AccountId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string AccountType { get; set; }
        public string  UserName{ get; set; }
        public string Password { get; set; }
    }
}
