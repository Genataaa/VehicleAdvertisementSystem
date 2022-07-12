namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Transmission
    {
        public Transmission()
            => this.Advertisement = new HashSet<Advertisement>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.TransmissionTypeMaxLength)]
        public string Type { get; set; }

        public ICollection<Advertisement> Advertisement { get; set; }
    }
}