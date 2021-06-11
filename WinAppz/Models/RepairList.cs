using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class RepairList
    {
        [Key]
        public int RepairListId { get; set; }
        public int RepairId { get; set; }
        public Repair Repair { get; set; }
        public string ItemName { get; set; }
        public string ItemFault { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "Decimal")]
        public decimal RepairPrice { get; set; }
    }
}
