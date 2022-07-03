namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class VehicleType
    {
        public VehicleType()
            => this.Vehicles = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.VehicleTypeMaxNameLength)]

        public int Name { get; set; }

        public ICollection<Advertisment> Vehicles { get; set; }
    }
}