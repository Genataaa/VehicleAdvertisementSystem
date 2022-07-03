using System.ComponentModel.DataAnnotations;

namespace VehicleAdvertisementSystem.Data.Models
{
    public class Transmission
    {
        public Transmission()
            => this.Vehicles = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.TransmissionTypeMaxLength)]
        public string Type { get; set; }

        public ICollection<Advertisment> Vehicles { get; set; }
    }
}