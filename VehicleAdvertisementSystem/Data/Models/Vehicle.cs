namespace VehicleAdvertisementSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Vehicle
    {
        public Vehicle()
        {
            this.Extras = new HashSet<Extra>();
            this.Images = new List<Image>();
        }

        public int Id { get; set; }

        public int VehicleTypeId { get; set; }

        public VehicleType VehicleType { get; set; }

        public int ConditionStatusId { get; set; }

        public ConditionStatus ConditionStatus { get; set; }

        [Required]
        [StringLength(DataConstants.VehicleMakeMaxLength)]
        public string Make { get; set; }

        [Required]
        [StringLength(DataConstants.VehicleModelMaxLength)]
        public string Model { get; set; }

        [Range(DataConstants.VehicleMileageMinValue, DataConstants.VehicleMileageMaxValue)]
        public long Mileage { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        public decimal Price { get; set; }

        public int TransmissionId { get; set; }

        public Transmission Transmission { get; set; }

        public int FuelId { get; set; }

        public Fuel Fuel { get; set; }

        [Range(DataConstants.VehiclePowerMinValue, DataConstants.VehiclePowerMaxValue)]
        public int Power { get; set; }

        public double CubicCapacity { get; set; }

        public DateTime ManifactureDate { get; set; }

        [Range(DataConstants.VehicleMinDoorsNumber, DataConstants.VehicleMaxDoorsNumber)]
        public int NumberOfDoors { get; set; }

        [Range(DataConstants.VehicleMinSeatsNumber, DataConstants.VehicleMaxSeatsNumber)]
        public int NumberOfSeats { get; set; }

        [Required]
        [StringLength(DataConstants.VehicleColorMaxLength)]
        public string Color { get; set; }

        public int? EurostandardId { get; set; }

        public Eurostandard? Eurostandard { get; set; }

        public bool NewImportation { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<Extra> Extras { get; set; }

        public int AdvertismentId { get; set; }

        public Advertisment Advertisment { get; set; }
    }
}
