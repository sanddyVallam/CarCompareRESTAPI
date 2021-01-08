using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCampareToolRESTAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarCampareToolRESTAPI.Controllers
{
    [ApiController]
    
    public class CarCompareController : ControllerBase
    {
        private readonly ICarCompareRepository _CompareRepo;

        public CarCompareController(ICarCompareRepository comareRepo)
        {
            _CompareRepo = comareRepo ?? throw new ArgumentNullException(nameof(comareRepo));
        }
        [HttpGet("api/CarCompare")]
        public ActionResult GetCarDetails()
        {
            var CarsRepo = _CompareRepo.GetCarData();
            return new JsonResult(CarsRepo);
        }
        [HttpGet("api/NewestVehicleInOrder/{year:int?}")]
        public ActionResult NewestVehicleInOrder(int year = 0)
        {
            var CarsRepo = _CompareRepo.NewestVehicleInOrder(year);
            if (CarsRepo.Count() == 0)
                return NotFound();
            return Ok(CarsRepo);
        }
        [HttpGet("api/OrderListofVehicle/{descending:bool?}")]
        public ActionResult OrderListofVehicle(bool descending = false)
        {
            var CarsRepo = _CompareRepo.OrderListofVehicle(descending);
            return new JsonResult(CarsRepo);
        }
        [HttpGet("api/RandomCarPickup")]
        public ActionResult RandomCarPickup()
        {
            var CarsRepo = _CompareRepo.RandomCarPickup();
            return new JsonResult(CarsRepo);
        }
        [HttpGet("api/Fuelconsumption/{distance:double?}")]
        public ActionResult Fuelconsumption(double distance = 0)
        {
            var CarsRepo = _CompareRepo.Fuelconsumption(distance);
            if (CarsRepo.Count() == 0)
                return NotFound();
            return Ok(CarsRepo);
        }
        [HttpGet("api/BestValue")]
        public ActionResult BestValue()
        {
            var CarsRepo = _CompareRepo.BestValue();
            return new JsonResult(CarsRepo);
        }
        [HttpGet("api/AvgMPG")]
        public ActionResult AvgMPG()
        {
            var CarsRepo = _CompareRepo.AvgMPG();
            return new JsonResult(CarsRepo);
        }
        [HttpGet("api/AlphabeticalVehicle/{isDescending:bool?}")]
        public ActionResult AlphabeticalVehicle(bool isDescending = false)
        {
            var CarsRepo = _CompareRepo.AlphabeticalVehicle(isDescending);
            return new JsonResult(CarsRepo);
        }

    }
}
