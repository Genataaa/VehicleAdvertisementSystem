namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ImageUrlMaxLength)]
        public string ImageUrl { get; init; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }
    }
}
