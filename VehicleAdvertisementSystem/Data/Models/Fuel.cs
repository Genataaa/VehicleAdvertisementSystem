namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Fuel
    {
        public Fuel()
            => this.Vehicles = new HashSet<Vehicle>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.FuelNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}