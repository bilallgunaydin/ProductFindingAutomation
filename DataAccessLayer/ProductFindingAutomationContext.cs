using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Mapping;
using DataAccessLayer.Migrations;
using Entities;

namespace DataAccessLayer
{
    public class ProductFindingAutomationContext : DbContext
    {
        private static ProductFindingAutomationContext _context { get; set; }

        public static ProductFindingAutomationContext ContextOlustur()
        {
            if (_context == null)
            {
                _context = new ProductFindingAutomationContext();
            }

            return _context;
        }

        public ProductFindingAutomationContext() : base("ProductFindingAutomation")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ProductFindingAutomationContext, Configuration>());
        }

        internal DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());


        }
    }
}
