namespace VehicleAdvertisementSystem.Infrastructure
{
    using Microsoft.EntityFrameworkCore;

    using Data;
    using VehicleAdvertisementSystem.Data.Models;

    public static class ApplicationBuilderExtention
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<AdvertisementSystemDbContext>();

            data.Database.Migrate();

            SeedConditionStatus(data);
            SeedEurostandards(data);
            SeedFuel(data);
            SeedTransmission(data);
            SeedVehicleTypes(data);

            return app;
        }

        private static void SeedConditionStatus(AdvertisementSystemDbContext data)
        {
            if (!data.ConditionStatuses.Any())
            {
                data.ConditionStatuses.AddRange(new[]
                {
                    new ConditionStatus {Name = "In good condition"},
                    new ConditionStatus {Name = "Damaged/Dumped"},
                    new ConditionStatus {Name = "Whole cars for parts"},
                });

                data.SaveChanges();
            }
        }

        private static void SeedEurostandards(AdvertisementSystemDbContext data)
        {
            if (!data.Eurostandards.Any())
            {
                data.Eurostandards.AddRange(new[]
                {
                    new Eurostandard { Name = "None"},
                    new Eurostandard { Name = "Euro 1"},
                    new Eurostandard { Name = "Euro 2"},
                    new Eurostandard { Name = "Euro 3"},
                    new Eurostandard { Name = "Euro 4"},
                    new Eurostandard { Name = "Euro 5"},
                    new Eurostandard { Name = "Euro 6"},
                });

                data.SaveChanges();
            }
        }

        private static void SeedFuel(AdvertisementSystemDbContext data)
        {
            if (!data.FuelTypes.Any())
            {
                data.FuelTypes.AddRange(new[]
                {
                    new Fuel {Name = "Gasoline"},
                    new Fuel {Name = "Diesel"},
                    new Fuel {Name = "Gas/Petrol"},
                    new Fuel {Name = "Methane/Gasoline"},
                    new Fuel {Name = "Hybrid"},
                    new Fuel {Name = "Electricity"},
                });

                data.SaveChanges();
            }
        }

        private static void SeedTransmission(AdvertisementSystemDbContext data)
        {
            if (!data.Transmissions.Any())
            {
                data.Transmissions.AddRange(new[]
                {
                    new Transmission {Type = "Manual"},
                    new Transmission {Type = "Automatic"},
                    new Transmission {Type = "Semi Automatic"},
                });

                data.SaveChanges();
            }
        }

        private static void SeedVehicleTypes(AdvertisementSystemDbContext data)
        {
            if (!data.VehicleTypes.Any())
            {
                data.VehicleTypes.AddRange(new[]
                {
                    new VehicleType {Name = "Cars"},
                    new VehicleType {Name = "Buses"},
                    new VehicleType {Name = "Trucks"},
                });

                data.SaveChanges();
            }
        }
    }
}
