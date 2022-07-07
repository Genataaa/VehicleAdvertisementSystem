namespace VehicleAdvertisementSystem.Models.Advertisments
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using VehicleAdvertisementSystem.Data;

    public class AddAdvertismentFormModel
    {
        [Display(Name = "Type vehicle")]
        public int VehicleTypeId { get; init; }

        [Display(Name = "Condition status")]
        public int ConditionStatusId { get; init; }

        [Required]
        [StringLength(DataConstants.VehicleMakeMaxLength)]
        public string Make { get; init; }

        [Required]
        [StringLength(DataConstants.VehicleModelMaxLength)]
        public string Model { get; init; }

        [Range(DataConstants.VehicleMileageMinValue, DataConstants.VehicleMileageMaxValue)]
        public long Mileage { get; init; }

        public int Price { get; init; }

        [Display(Name = "Transmission type")]
        public int TransmissionId { get; init; }

        [Display(Name = "Fule")]
        public int FuelId { get; init; }

        [Range(DataConstants.VehiclePowerMinValue, DataConstants.VehiclePowerMaxValue)]
        public int Power { get; init; }

        public int NumberOfDoors { get; init; }

        public int NumberOfSeats { get; init; }

        [Required]
        public string Color { get; init; }

        [Display(Name = "Eurostandard")]
        public int? EurostandardId { get; init; }

        public bool NewImportation { get; init; }

        [Required]
        public string Description { get; init; }

        public IEnumerable<VehicleTypeViewModel> VehicleTypes { get; set; }

        public IEnumerable<ConditionStatusViewModel> ConditionStatuses { get; set; }

        public IEnumerable<TransmissionTypeViewModel> TransmissionTypes { get; set; }

        public IEnumerable<FuelVielModel> FuelTypes { get; set; }

        public IEnumerable<EurostandardVielModel> Eurostandards { get; set; }
    }
}
