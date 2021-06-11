using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Repair
    {
        [Key]
        public int RepairId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public bool RepairStatus { get; set; }
        public decimal RepairTotal { get; set; }
        [Column(TypeName ="Date")]
        public DateTime Bookon { get; set; }
    }
}
