using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flight_n_Bite_API.Model;
using Flight_n_Bite_API.Model.DTO;
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
        public ActionResult<Passenger> LogIn(Passenger model)
        {
            var passenger = _passengerRepository.GetPassenger(model.FirstName, model.LastName, model.SeatIdentifier);
            return passenger == null ? (ActionResult<Passenger>)BadRequest() : (ActionResult<Passenger>)passenger;
        }

        [AllowAnonymous]
        [HttpPost("switchSeats")]
        public Boolean SwitchSeats(SwitchsSeatsDTO model)
        {

            if (model.Passenger1 == null && model.Passenger2 == null)
            {
                return false;
            }
            if (model.Passenger1 != null)
            {
                _passengerRepository.Update(model.Passenger1);
                _passengerRepository.SaveChanges();
            }
            if (model.Passenger2 != null)
            {
                _passengerRepository.Update(model.Passenger2);
                _passengerRepository.SaveChanges();
            }
            return true;

        }
    }
}