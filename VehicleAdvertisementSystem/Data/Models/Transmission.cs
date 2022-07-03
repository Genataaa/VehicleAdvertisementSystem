namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Transmission
    {
        public Transmission()
            => this.Advertisments = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.TransmissionTypeMaxLength)]
        public string Type { get; set; }

        public ICollection<Advertisment> Advertisments { get; set; }
    }
}