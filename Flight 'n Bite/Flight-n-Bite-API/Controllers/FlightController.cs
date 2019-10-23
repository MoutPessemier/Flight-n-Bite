using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase

    {
        private readonly IFlightRepository _flightRepository;

        public FlightController(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        [HttpGet]
        public Flight GetCurrentFlight()
        {
            return _flightRepository.GetFlight();
        }
    }
}