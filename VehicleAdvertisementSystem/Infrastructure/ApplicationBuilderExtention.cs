namespace VehicleAdvertisementSystem.Infrastructure
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using VehicleAdvertisementSystem.Data.Models;

    public static class ApplicationBuilderExtention
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<AdvertismentSystemDbContext>();

            data.Database.Migrate();

            SeedConditionStatus(data);
            SeedEurostandards(data);
            SeedExtras(data);
            SeedFuel(data);
            SeedTransmission(data);
            SeedVehicleTypes(data);

            return app;
        }

        private static void SeedConditionStatus(AdvertismentSystemDbContext data)
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

        private static void SeedEurostandards(AdvertismentSystemDbContext data)
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

        private static void SeedExtras(AdvertismentSystemDbContext data)
        {
            if (!data.Extras.Any())
            {
                data.Extras.AddRange(new[]
                {
                    new Extra {Name = "Air Conditioner"},
                    new Extra {Name = "Climatronic"},
                    new Extra {Name = "Electric glass"},
                    new Extra {Name = "Electric mirrors"},
                    new Extra {Name = "Electric seats"},
                    new Extra {Name = "Seat heating"},
                    new Extra {Name = "Shibedah"},
                    new Extra {Name = "Stereo"},
                    new Extra {Name = "Alloy wheels"},
                    new Extra {Name = "DVD/TV"},
                    new Extra {Name = "Multifunction steering wheel"},
                    new Extra {Name = "4x4"},
                    new Extra {Name = "ABS"},
                    new Extra {Name = "ESP"},
                    new Extra {Name = "Airbag"},
                    new Extra {Name = "Xenon lights"},
                    new Extra {Name = "Halogen headlights"},
                    new Extra {Name = "ASR/Traction Control"},
                    new Extra {Name = "Parktronic"},
                    new Extra {Name = "Alarm"},
                    new Extra {Name = "Immobilizer"},
                    new Extra {Name = "Center. lock"},
                    new Extra {Name = "Insurance"},
                    new Extra {Name = "Armored"},
                    new Extra {Name = "Start-Stop system"},
                    new Extra {Name = "Keyless ignition"},
                    new Extra {Name = "Tiptronic/Multitronic"},
                    new Extra {Name = "Autopilot"},
                    new Extra {Name = "Power Steering"},
                    new Extra {Name = "On-board computer"},
                    new Extra {Name = "Service book"},
                    new Extra {Name = "Warranty"},
                    new Extra {Name = "Navigation system"},
                    new Extra {Name = "Right hand drive"},
                    new Extra {Name = "Tuning"},
                    new Extra {Name = "Panoramic roof"},
                    new Extra {Name = "TAXI"},
                    new Extra {Name = "Retro"},
                    new Extra {Name = "Tow truck"},
                    new Extra {Name = "7 seats (6+1)"},
                    new Extra {Name = "Refrigerated"},
                });

                data.SaveChanges();
            }
        }

        private static void SeedFuel(AdvertismentSystemDbContext data)
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

        private static void SeedTransmission(AdvertismentSystemDbContext data)
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

        private static void SeedVehicleTypes(AdvertismentSystemDbContext data)
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
