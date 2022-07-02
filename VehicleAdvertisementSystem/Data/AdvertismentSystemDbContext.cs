﻿namespace VehicleAdvertisementSystem.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using VehicleAdvertisementSystem.Data.Models;

    public class AdvertismentSystemDbContext : IdentityDbContext
    {
        public AdvertismentSystemDbContext(DbContextOptions<AdvertismentSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Advertisment> Advertisments { get; set; }

        public DbSet<ConditionStatus> ConditionStatuses { get; set; }

        public DbSet<Eurostandard> Eurostandards { get; set; }

        public DbSet<Extra> Extras { get; set; }

        public DbSet<Fuel> FuelTypes { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Transmission> Transmissions { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Advertisment>()
                .HasOne(v => v.Vehicle)
                .WithOne(a => a.Advertisment)
                .HasForeignKey<Vehicle>(x => x.AdvertismentId);

            base.OnModelCreating(builder);
        }
    }
}