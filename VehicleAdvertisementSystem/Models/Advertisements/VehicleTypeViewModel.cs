namespace VehicleAdvertisementSystem.Models.Advertisements
{
    using System.ComponentModel.DataAnnotations;

    public class VehicleTypeViewModel
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}
