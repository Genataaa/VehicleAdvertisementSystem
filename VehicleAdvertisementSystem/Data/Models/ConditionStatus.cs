namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class ConditionStatus
    {
        public ConditionStatus()
            => this.Advertisments = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ConditionNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Advertisment> Advertisments { get; set; }
    }
}