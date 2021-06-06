using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int RepairId { get; set; }
        public Repair Repair { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string PaymentMethod { get; set; }
       // [Column("Decimal")]
        public decimal PaymentStatus { get; set; }
        //[Column("Decimal")]
        public decimal TotalAmountDue { get; set; }
    }
}
