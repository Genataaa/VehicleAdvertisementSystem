namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VehicleType
    {
        public VehicleType()
            => this.Advertisement = new HashSet<Advertisement>();

        public int Id { get; init; }

        [Required]
        [StringLength(DataConstants.VehicleTypeMaxNameLength)]
        public string Name { get; init; }

        public ICollection<Advertisement> Advertisement { get; set; }
    }
}