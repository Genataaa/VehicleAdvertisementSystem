namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Eurostandard
    {
        public Eurostandard()
            => this.Vehicles = new HashSet<Vehicle>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.EurostandardNameMaxLength)]
        public string Name { get; set; }

        ICollection<Vehicle> Vehicles { get; set; }
    }
}