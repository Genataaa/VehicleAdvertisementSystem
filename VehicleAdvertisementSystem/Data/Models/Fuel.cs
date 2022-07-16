namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Fuel
    {
        public Fuel()
            => this.Advertisement = new HashSet<Advertisement>();

        public int Id { get; init; }

        [Required]
        [StringLength(DataConstants.FuelNameMaxLength)]
        public string Name { get; init; }

        public ICollection<Advertisement> Advertisement { get; set; }
    }
}