namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Eurostandard
    {
        public Eurostandard()
            => this.Advertisement = new HashSet<Advertisement>();

        public int Id { get; init; }

        [Required]
        [StringLength(DataConstants.EurostandardNameMaxLength)]
        public string Name { get; init; }

        ICollection<Advertisement> Advertisement { get; set; }
    }
}