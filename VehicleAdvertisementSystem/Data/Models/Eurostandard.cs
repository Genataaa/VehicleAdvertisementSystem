namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Eurostandard
    {
        public Eurostandard()
            => this.Vehicles = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.EurostandardNameMaxLength)]
        public string Name { get; set; }

        ICollection<Advertisment> Vehicles { get; set; }
    }
}