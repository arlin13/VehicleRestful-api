using System.Linq;
using System.Web.Http;
using VehicleRestful_api.Data;

namespace VehicleRestful_api.Controllers
{
    public class VehicleController : ApiController
    {
        private VehicleRestfulDataContext db = new VehicleRestfulDataContext();

        // GET: api/Vehicles
        [HttpGet, Route("api/getVehicles")]
        public IHttpActionResult GetVehicles()
        {
            var resultSet = db.Vehicles.Select(vehicle => new
            {
                vehicle.VehicleId,
                vehicle.Make,
                vehicle.Model,
                vehicle.Year
            });
            return Ok(resultSet);
        }
    }
}
