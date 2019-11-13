using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flight_n_Bite_API.Model;
using Microsoft.AspNetCore.Authorization;
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
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<Passenger>> LogIn(Passenger model)
        {
            var passenger = _passengerRepository.GetPassenger(model.SeatIdentifier);
            if (passenger != null)
            {
                if(passenger.FirstName == model.FirstName && passenger.LastName == model.LastName)
                {
                    return passenger;
                }
                else
                {
                    return null;
                }

            }
            return BadRequest();
        }
    }
}