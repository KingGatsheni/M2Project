using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int Quantity { get; set; }
        public int SellingPrice { get; set; }
        public string Description { get; set; }
    }
}
