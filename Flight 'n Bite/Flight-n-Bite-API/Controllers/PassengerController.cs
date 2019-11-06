using System.Collections.Generic;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerRepository _passengerRepository;

        public PassengerController(IPassengerRepository passengerRepository)
        {
            _passengerRepository = passengerRepository;
        }

        [HttpGet]
        public List<Passenger> GetPassengers()
        {
            return _passengerRepository.GetPassengers();
        }

        [HttpGet("{id}")]
        public Passenger GetPassenger(int id)
        {
            return _passengerRepository.GetPassenger(id);
        }
    }
}