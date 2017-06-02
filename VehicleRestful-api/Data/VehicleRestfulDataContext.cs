using System.Collections.Generic;
using System.Data.Entity;
using VehicleRestful_api.Models;

namespace VehicleRestful_api.Data
{
    public class VehicleRestfulDataContext : DbContext
    {
        public List<Vehicle> Vehicles { get; set; }

        public VehicleRestfulDataContext()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}