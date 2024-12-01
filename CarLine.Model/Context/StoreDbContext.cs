using CarLine.Model.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLine.Model.Context
{
    public class StoreDbContext : IdentityDbContext<AppSeller>
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Car> Cars { get; set; }    
        public DbSet<CarShowRoom>  CarShowRooms { get; set; }

        public DbSet<Phone>  Phones { get; set; }

        public DbSet<Picture> Pictures { get; set; }

        public DbSet<Wanch> Wanches { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Equipment>  Equipments { get; set; }
        public DbSet<CarBrand>   CarBrands { get; set; }
        public DbSet<MaintenanceCenter>   MaintenanceCenters { get; set; }


















    }
}
