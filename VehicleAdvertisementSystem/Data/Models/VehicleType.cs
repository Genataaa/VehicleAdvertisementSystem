namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VehicleType
    {
        public VehicleType()
            => this.Advertisement = new HashSet<Advertisement>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.VehicleTypeMaxNameLength)]
        public string Name { get; set; }

        public ICollection<Advertisement> Advertisement { get; set; }
    }
}