namespace VehicleAdvertisementSystem.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using VehicleAdvertisementSystem.Data.Models;

    public class AdvertisementSystemDbContext : IdentityDbContext
    {
        public AdvertisementSystemDbContext(DbContextOptions<AdvertisementSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<ConditionStatus> ConditionStatuses { get; set; }

        public DbSet<Eurostandard> Eurostandards { get; set; }

        public DbSet<Fuel> FuelTypes { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Transmission> Transmissions { get; set; }

        public DbSet<Advertisement> Advertisements { get; set; }

        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}