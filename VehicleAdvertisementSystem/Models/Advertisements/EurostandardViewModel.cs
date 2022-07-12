namespace VehicleAdvertisementSystem.Models.Advertisments
{
    using System.ComponentModel.DataAnnotations;

    public class EurostandardViewModel
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}
