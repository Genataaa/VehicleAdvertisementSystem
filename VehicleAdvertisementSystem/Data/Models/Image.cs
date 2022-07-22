namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; init; }

        [Required]
        public string ImageUrl { get; init; }

        public int AdvertismentId { get; init; }

        public Advertisement Advertisement { get; set; }
    }
}
