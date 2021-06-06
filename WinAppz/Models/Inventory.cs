using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class Inventory
    {
        [Key]
        public int InventoryId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
       // [Column("Decimal")]
        public decimal CostPrice { get; set; }
       // [Column("Decimal")]
        public decimal Markup { get; set; }
       // [Column("Decimal")]
        public decimal SellingPrice { get; set; }
        public int Quantity { get; set; }
    }
}
