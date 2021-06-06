using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Cell_No { get; set; }
        public string Email { get; set; }
        public string address { get; set; }
    }
}
