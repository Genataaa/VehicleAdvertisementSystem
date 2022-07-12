namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ConditionStatus
    {
        public ConditionStatus()
            => this.Advertisements = new HashSet<Advertisement>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ConditionNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Advertisement> Advertisements { get; set; }
    }
}