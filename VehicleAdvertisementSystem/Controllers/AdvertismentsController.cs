namespace VehicleAdvertisementSystem.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Models.Advertisments;

    public class AdvertismentsController : Controller
    {
        public IActionResult Add() => View();

        [HttpPost]
        public IActionResult Add(AddAdvertismentFormModel advertisment)
        {
            return View();
        }
    }
}
