namespace VehicleAdvertisementSystem.Infrastructure
{
    using Data;
    using Microsoft.EntityFrameworkCore;

    public static class ApplicationBuilderExtention
    {
        public static IApplicationBuilder PrepareDatabase(
            this IApplicationBuilder app)
        {
            using var scopedServices = app.ApplicationServices.CreateScope();

            var data = scopedServices.ServiceProvider.GetService<AdvertismentSystemDbContext>();

            data.Database.Migrate();

            return app;
        }
    }
}
