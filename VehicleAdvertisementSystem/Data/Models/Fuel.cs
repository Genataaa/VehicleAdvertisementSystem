namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Fuel
    {
        public Fuel()
            => this.Advertisments = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.FuelNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Advertisment> Advertisments { get; set; }
    }
}