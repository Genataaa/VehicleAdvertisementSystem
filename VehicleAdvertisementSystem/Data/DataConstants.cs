namespace VehicleAdvertisementSystem.Data
{
    public class DataConstants
    {
        //Advertisment
        public const int VehicleMakeMaxLength = 30;

        public const int VehicleModelMaxLength = 30;

        public const int VehicleMileageMinValue = 0;

        public const long VehicleMileageMaxValue = long.MaxValue;

        public const int VehiclePowerMinValue = 10;

        public const int VehiclePowerMaxValue = 1500;

        public const int VehicleMinDoorsNumber = 2;

        public const int VehicleMaxDoorsNumber = 6;

        public const int VehicleMinSeatsNumber = 1;

        public const int VehicleMaxSeatsNumber = 50;

        public const int VehicleColorMaxLength = 20;

        public const int DescriptionMinLength = 20;

        public const int DescriptionMaxLength = int.MaxValue;

        //ConditionStatus
        public const int ConditionNameMaxLength = 20;

        //Eurostandard
        public const int EurostandardNameMaxLength = 20;

        //Fuel
        public const int FuelNameMaxLength = 20;

        //Transmission
        public const int TransmissionTypeMaxLength = 30;

        //VehicleType
        public const int VehicleTypeMaxNameLength = 20;
    }
}
