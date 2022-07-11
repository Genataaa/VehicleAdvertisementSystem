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
            if (!this.data.VehicleTypes.Any(t => t.Id == advertisment.VehicleTypeId))
            {
                this.ModelState.AddModelError(nameof(advertisment.VehicleTypeId), "Vehicle type does not exist.");
            }

            if (this.data.ConditionStatuses.Any(c => c.Id == advertisment.ConditionStatusId))
            {
                this.ModelState.AddModelError(nameof(advertisment.ConditionStatusId), "Condition status does not exist.");
            }

            if (this.data.Transmissions.Any(t => t.Id == advertisment.TransmissionId))
            {
                this.ModelState.AddModelError(nameof(advertisment.TransmissionId), "Transmission type does not exist.");
            }

            if (this.data.FuelTypes.Any(t => t.Id == advertisment.FuelId))
            {
                this.ModelState.AddModelError(nameof(advertisment.FuelId), "Fuel type does not exist.");
            }

            if (this.data.Eurostandards.Any(t => t.Id == advertisment.EurostandardId))
            {
                this.ModelState.AddModelError(nameof(advertisment.EurostandardId), "Eurostanderd does not exist.");
            }

            if (!ModelState.IsValid)
            {
                advertisment.VehicleTypes = this.GetVehicleTypes();
                advertisment.ConditionStatuses = this.GetConditionStatuses();
                advertisment.TransmissionTypes = this.GetTransmissionTypes();
                advertisment.FuelTypes = this.GetFuelTypes();
                advertisment.Eurostandards = this.GetEurostandards();
                return View(advertisment);
            }

            var advertismentData = new Advertisment
            {
                VehicleTypeId = advertisment.VehicleTypeId,
                ConditionStatusId = advertisment.ConditionStatusId,
                Make = advertisment.Make,
                Model = advertisment.Model,
                Mileage = advertisment.Mileage,
                Price = advertisment.Price,
                TransmissionId = advertisment.TransmissionId,
                FuelId = advertisment.FuelId,
                Power = advertisment.Power,
                Year = advertisment.Year,
                Month = advertisment.Month,
                NumberOfDoors = advertisment.NumberOfDoors,
                NumberOfSeats = advertisment.NumberOfSeats,
                Color = advertisment.Color,
                EurostandardId = advertisment.EurostandardId,
                NewImportation = advertisment.NewImportation,
                DateOfPublication = DateTime.UtcNow,
                Description = advertisment.Description,
            };

            this.data.Advertisments.Add(advertismentData);
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
