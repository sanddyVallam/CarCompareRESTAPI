using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCampareToolRESTAPI.DbContexts;
using CarCampareToolRESTAPI.Model;

namespace CarCampareToolRESTAPI.Services
{
    public class CarCompareRepository : ICarCompareRepository
    {
        private readonly CarCompareContext _CarCompareContext;
        
        private static double AvgFuelCost = 2.0;
        private static int MinMilagePerYear = 12000;

        public CarCompareRepository(CarCompareContext Contexts)
        {
            _CarCompareContext = Contexts ?? throw new ArgumentNullException(nameof(Contexts));
        }
        public IEnumerable<CarModelCommon> AlphabeticalVehicle(bool? isDescending)
        {
            if (isDescending == null)
                isDescending = false;

            if (isDescending.HasValue)
                return _CarCompareContext.CarModel.OrderByDescending(s => s.Make);
            else
                return _CarCompareContext.CarModel.OrderBy(s => s.Make);
        }

        public IEnumerable<AvgMPGPerYearModel> AvgMPG()
        {
            var AvgerageMPG = _CarCompareContext.CarModel
                            .GroupBy(s => s.Year)
                            .Select(g => new AvgMPGPerYearModel { Year = g.Key, Avg = g.Average(s => s.HwMPG) }).ToList();

            return AvgerageMPG;
        }

        public IEnumerable<CarModelCommon> BestValue()
        {
            //var MinMilesPerYear = 12000;
            //var AvgFuel = 2.0;
            var Vehicles = _CarCompareContext.CarModel.ToList();
            foreach (var EachCar in Vehicles)
            {
                EachCar.BestValue = Convert.ToDouble(EachCar.Price) + ((MinMilagePerYear / EachCar.HwMPG) * AvgFuelCost);

            }
            var MinValue = Vehicles.AsQueryable().Min(s => s.BestValue);
            return Vehicles.Where(s => s.BestValue == MinValue).ToList();
        }

        public IEnumerable<CarModelCommon> Fuelconsumption(double? distance)
        {
            if (distance == null)
                distance = 0;
            var Vehicles = _CarCompareContext.CarModel.ToList();
            foreach (var EachVeh in Vehicles)
            {
                EachVeh.FuelConsumption = (distance.Value / EachVeh.HwMPG);
            }       
            return Vehicles;
        }

        public IEnumerable<CarModelCommon> GetCarData()
        {
            
            return _CarCompareContext.CarModel;
        }

        public IEnumerable<CarModelCommon> NewestVehicleInOrder(int? Year)
        {
            //Get Data of CarCompare
            var NewVehicle = _CarCompareContext.CarModel;
            //Assign variable Year with Max Year of table if it is null
            if (Year == null || Year == 0)
                Year = NewVehicle.AsQueryable().Max(s => s.Year);

            return NewVehicle.AsQueryable().Where(s => s.Year == Year).ToList();
        }

        public IEnumerable<CarModelCommon> OrderListofVehicle(bool? isDescending)
        {
            if (isDescending == null)
                isDescending = false;

            if(isDescending.HasValue)
                return _CarCompareContext.CarModel.OrderByDescending(s => s.Price).ToList();
            else
                return _CarCompareContext.CarModel.OrderBy(s => s.Price).ToList();
        }

        public CarModelCommon RandomCarPickup()
        {
            var random = new Random();
            var Vehicles = _CarCompareContext.CarModel.ToArray();
            int index = random.Next(Vehicles.Count());
            return Vehicles[index];
        }
    }
}
