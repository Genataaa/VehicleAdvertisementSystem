namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; init; }

        public int AdvertismentId { get; set; }

        public Advertisement Advertisement { get; set; }
    }
}
