using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarCampareToolRESTAPI.Model;

namespace CarCampareToolRESTAPI.Services
{
    public interface ICarCompareRepository
    {
        IEnumerable<CarModelCommon> GetCarData();
        IEnumerable<CarModelCommon> NewestVehicleInOrder(int? Year);
        IEnumerable<CarModelCommon> AlphabeticalVehicle(bool? isDescending);
        IEnumerable<CarModelCommon> OrderListofVehicle(bool? isDescending);
        IEnumerable<CarModelCommon> BestValue();
        IEnumerable<CarModelCommon> Fuelconsumption(double? distance);
        CarModelCommon RandomCarPickup();
        IEnumerable<AvgMPGPerYearModel> AvgMPG();
    }
}
