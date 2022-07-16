namespace VehicleAdvertisementSystem.Models.Advertisements
{
    using System.ComponentModel.DataAnnotations;

    public class FuelViewModel
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}
