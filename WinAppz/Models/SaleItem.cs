using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class SaleItem
    {
        [Key]
        public int SaleItemId { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int Quantity { get; set; }
        public decimal ItemPrice { get; set; }

        
    }
}
