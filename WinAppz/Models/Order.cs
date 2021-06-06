using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; }
        //[Column("Date")]
        public string Date { get; set; }
        //[Column("Decimal")]
        public decimal  Total { get; set; }
        public bool OrderStatus { get; set; }
    }
}
