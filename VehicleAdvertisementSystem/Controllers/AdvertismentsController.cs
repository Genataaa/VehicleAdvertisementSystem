namespace VehicleAdvertisementSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models.Advertisments;
    using VehicleAdvertisementSystem.Data;

    public class AdvertismentsController : Controller
    {
        private readonly AdvertismentSystemDbContext data;

        public AdvertismentsController(AdvertismentSystemDbContext data)
        {
            this.data = data;
        }

        public IActionResult Add() => View(new AddAdvertismentFormModel
        {
            VehicleTypes = this.GetVehicleTypes(),
            ConditionStatuses = this.GetConditionStatuses(),
            TransmissionTypes = this.GetTransmissionTypes(),
            FuelTypes = this.GetFuelTypes(),
            Eurostandards = this.GetEurostandards(),
        });

        [HttpPost]
        public IActionResult Add(AddAdvertismentFormModel advertisment)
        {
            return View();
        }

        private IEnumerable<VehicleTypeViewModel> GetVehicleTypes()
            => this.data
            .VehicleTypes
            .Select(t => new VehicleTypeViewModel
            {
                Id = t.Id,
                Name = t.Name,
            })
            .ToList();

        private IEnumerable<ConditionStatusViewModel> GetConditionStatuses()
            => this.data
            .ConditionStatuses
            .Select(x => new ConditionStatusViewModel
            {
                Id = x.Id,
                Name = x.Name,
            })
            .ToList();

        private IEnumerable<TransmissionTypeViewModel> GetTransmissionTypes()
            => this.data
            .Transmissions
            .Select(x => new TransmissionTypeViewModel
            {
                Id = x.Id,
                Type = x.Type,
            })
            .ToList();

        private IEnumerable<FuelVielModel> GetFuelTypes()
            => this.data
            .FuelTypes
            .Select(x => new FuelVielModel
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToList();

        private IEnumerable<EurostandardVielModel> GetEurostandards()
            => this.data
            .Eurostandards
            .Select(x => new EurostandardVielModel
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToList();
    }
}
