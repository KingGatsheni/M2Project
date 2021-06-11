using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2PcWizard_POS.Models
{
    class ModelDbContext:DbContext
    {
        public ModelDbContext(): base("name =con")
        {
                
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Sale> Orders { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Repair> Repairs { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<SaleItem> OrderItems { get; set; }
        public DbSet<RepairList> RepairLists { get; set; }
        public DbSet<Inventory> Inventorys { get; set; }

    }
}
