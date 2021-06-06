using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public long StuffId { get; set; }
        public string Firstname { get; set; }
        public string LastnName { get; set; }
        public string ID { get; set; }
        public string Cell_No { get; set; }
        public string Email { get; set; }
        public string EmployeeRole { get; set; }
        public string Address { get; set; }
    }
}
