namespace VehicleAdvertisementSystem.Models.Advertisements
{
    using System.ComponentModel.DataAnnotations;

    public class TransmissionTypeViewModel
    {
        public int Id { get; init; }

        [Required]
        public string Type { get; init; }
    }
}
