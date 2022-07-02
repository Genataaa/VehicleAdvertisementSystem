namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VehicleType
    {
        public VehicleType()
            => this.Vehicles = new HashSet<Vehicle>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.VehicleTypeMaxNameLength)]

        public int Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}