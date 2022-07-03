namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Extra
    {
        public Extra()
            => this.Advertisments = new HashSet<Advertisment>();

        public int Id { get; set; }

        [Required]
        [StringLength(DataConstants.ExtraNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Advertisment> Advertisments { get; set; }
    }
}
