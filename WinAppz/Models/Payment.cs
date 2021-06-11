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
        public int? SaleId { get; set; }
        public Sale Sale { get; set; }
        public int? RepairId { get; set; }
        public virtual Repair Repair { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string PaymentMethod { get; set; }
        [Column(TypeName ="Decimal")]
        public decimal TotalAmount { get; set; }

        
    }
}
