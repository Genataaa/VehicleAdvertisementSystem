namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using VehicleAdvertisementSystem.Data;

    public class Advertisment
    {
        public int Id { get; set; }

        public DateTime DateOfPublication { get; set; }

        public int ViewsCounter { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        [Required]
        [StringLength(DataConstants.DescriptionMaxLength, MinimumLength = DataConstants.DescriptionMinLength)]
        public string Description { get; set; }
    }
}
