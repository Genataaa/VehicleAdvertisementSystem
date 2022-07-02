namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ConditionStatus
    {
        public ConditionStatus()
            => this.Vehicles = new HashSet<Vehicle>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ConditionNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}