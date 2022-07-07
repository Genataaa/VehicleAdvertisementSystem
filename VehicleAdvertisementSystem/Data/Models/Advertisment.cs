namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Advertisment
    {
        public Advertisment()
        {
            this.Images = new List<Image>();
            this.DateOfPublication = DateTime.UtcNow;
        }

        public int Id { get; init; }

        public int VehicleTypeId { get; init; }

        public VehicleType VehicleType { get; init; }

        public int ConditionStatusId { get; init; }

        public ConditionStatus ConditionStatus { get; init; }

        [Required]
        [StringLength(DataConstants.VehicleMakeMaxLength)]
        public string Make { get; init; }

        [Required]
        [StringLength(DataConstants.VehicleModelMaxLength)]
        public string Model { get; init; }

        [Range(DataConstants.VehicleMileageMinValue, DataConstants.VehicleMileageMaxValue)]
        public long Mileage { get; init; }

        public int Price { get; init; }

        public int TransmissionId { get; init; }

        public Transmission Transmission { get; init; }

        public int FuelId { get; init; }

        public Fuel Fuel { get; init; }

        [Range(DataConstants.VehiclePowerMinValue, DataConstants.VehiclePowerMaxValue)]
        public int Power { get; init; }

        public int Year { get; init; }

        public int Month { get; init; }

        [Range(DataConstants.VehicleMinDoorsNumber, DataConstants.VehicleMaxDoorsNumber)]
        public int NumberOfDoors { get; init; }

        [Range(DataConstants.VehicleMinSeatsNumber, DataConstants.VehicleMaxSeatsNumber)]
        public int NumberOfSeats { get; init; }

        [Required]
        [StringLength(DataConstants.VehicleColorMaxLength)]
        public string Color { get; init; }

        public int? EurostandardId { get; init; }

        public Eurostandard? Eurostandard { get; init; }

        public bool NewImportation { get; init; }

        public ICollection<Image> Images { get; set; }

        public DateTime DateOfPublication { get; init; }

        public int ViewsCounter { get; private set; }

        [Required]
        [StringLength(DataConstants.DescriptionMaxLength, MinimumLength = DataConstants.DescriptionMinLength)]
        public string Description { get; init; }
    }
}
