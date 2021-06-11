using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        [Column(TypeName ="Decimal")]
        public decimal  Total { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Date { get; set; }
    }
}
