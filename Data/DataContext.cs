using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}
        public DbSet<Property> Properties { get; set; }
        public DbSet<Full_Contract> Full_Contract { get; set; }
        public DbSet<Property_Service> Property_Services { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Property_Status> Property_Statuses { get; set; }
        public DbSet<Property_Type> property_Types { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}