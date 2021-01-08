using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarCampareToolRESTAPI.Model
{
    public class CarModelCommon
    {
        [Key]
        public int id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public double TCCRating { get; set; }
        public int HwMPG { get; set; }
        public double BestValue { get; set; }
        public double FuelConsumption { get; set; }
    }
}
