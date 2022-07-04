namespace VehicleAdvertisementSystem.Models.Advertisments
{
    public class AddAdvertismentFormModel
    {
        public int VehicleTypeId { get; init; }

        public int ConditionStatusId { get; init; }

        public string Make { get; init; }

        public string Model { get; init; }

        public long Mileage { get; init; }

        public decimal Price { get; init; }

        public int TransmissionId { get; init; }

        public int FuelId { get; init; }

        public int Power { get; init; }

        public double CubicCapacity { get; init; }

        public DateTime ManifactureDate { get; init; }

        public int NumberOfDoors { get; init; }

        public int NumberOfSeats { get; init; }

        public string Color { get; init; }

        public int EurostandardId { get; init; }

        public bool NewImportation { get; init; }

        public string Description { get; init; }
    }
}
