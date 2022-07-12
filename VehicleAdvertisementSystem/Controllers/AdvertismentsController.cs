namespace VehicleAdvertisementSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models.Advertisments;
    using VehicleAdvertisementSystem.Data;
    using Data.Models;

    public class AdvertismentsController : Controller
    {
        private readonly AdvertismentSystemDbContext data;

        public AdvertismentsController(AdvertismentSystemDbContext data)
            => this.data = data;

        public IActionResult Add() => View(new AddAdvertisementFormModel
        {
            VehicleTypes = this.GetVehicleTypes(),
            ConditionStatuses = this.GetConditionStatuses(),
            TransmissionTypes = this.GetTransmissionTypes(),
            FuelTypes = this.GetFuelTypes(),
            Eurostandards = this.GetEurostandards(),
        });

        [HttpPost]
        public IActionResult Add(AddAdvertisementFormModel advertisement)
        {
            if (!this.data.VehicleTypes.Any(t => t.Id == advertisement.VehicleTypeId))
            {
                this.ModelState.AddModelError(nameof(advertisement.VehicleTypeId), "Vehicle type does not exist.");
            }

            if (!this.data.ConditionStatuses.Any(c => c.Id == advertisement.ConditionStatusId))
            {
                this.ModelState.AddModelError(nameof(advertisement.ConditionStatusId), "Condition status does not exist.");
            }

            if (!this.data.Transmissions.Any(t => t.Id == advertisement.TransmissionId))
            {
                this.ModelState.AddModelError(nameof(advertisement.TransmissionId), "Transmission type does not exist.");
            }

            if (!this.data.FuelTypes.Any(t => t.Id == advertisement.FuelId))
            {
                this.ModelState.AddModelError(nameof(advertisement.FuelId), "Fuel type does not exist.");
            }

            if (!this.data.Eurostandards.Any(t => t.Id == advertisement.EurostandardId))
            {
                this.ModelState.AddModelError(nameof(advertisement.EurostandardId), "Eurostanderd does not exist.");
            }

            if (!ModelState.IsValid)
            {
                advertisement.VehicleTypes = this.GetVehicleTypes();
                advertisement.ConditionStatuses = this.GetConditionStatuses();
                advertisement.TransmissionTypes = this.GetTransmissionTypes();
                advertisement.FuelTypes = this.GetFuelTypes();
                advertisement.Eurostandards = this.GetEurostandards();
                return View(advertisement);
            }

            var advertismentData = new Advertisement
            {
                VehicleTypeId = advertisement.VehicleTypeId,
                ConditionStatusId = advertisement.ConditionStatusId,
                Make = advertisement.Make,
                Model = advertisement.Model,
                Mileage = advertisement.Mileage,
                Price = advertisement.Price,
                TransmissionId = advertisement.TransmissionId,
                FuelId = advertisement.FuelId,
                Power = advertisement.Power,
                Year = advertisement.Year,
                Month = advertisement.Month,
                NumberOfDoors = advertisement.NumberOfDoors,
                NumberOfSeats = advertisement.NumberOfSeats,
                Color = advertisement.Color,
                EurostandardId = advertisement.EurostandardId,
                NewImportation = advertisement.NewImportation,
                DateOfPublication = DateTime.UtcNow,
                Description = advertisement.Description,
            };

            this.data.Advertisements.Add(advertismentData);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
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

        private IEnumerable<FuelViewModel> GetFuelTypes()
            => this.data
            .FuelTypes
            .Select(x => new FuelViewModel
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToList();

        private IEnumerable<EurostandardViewModel> GetEurostandards()
            => this.data
            .Eurostandards
            .Select(x => new EurostandardViewModel
            {
                Id = x.Id,
                Name = x.Name
            })
            .ToList();
    }
}
