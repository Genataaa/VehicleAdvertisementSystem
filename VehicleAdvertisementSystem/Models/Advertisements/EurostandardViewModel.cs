namespace VehicleAdvertisementSystem.Models.Advertisments
{
    using System.ComponentModel.DataAnnotations;

    public class EurostandardVielModel
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}
