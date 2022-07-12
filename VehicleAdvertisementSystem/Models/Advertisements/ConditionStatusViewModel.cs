namespace VehicleAdvertisementSystem.Models.Advertisments
{
    using System.ComponentModel.DataAnnotations;

    public class ConditionStatusViewModel
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; init; }
    }
}
