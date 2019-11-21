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
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;

        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }

        [HttpGet]
        public List<Group> GetGroups()
        {
            return _groupRepository.GetGroups();
        }

        [HttpGet("{passengerId}")]
        public Group GetGroup(int passengerId)
        {
            return _groupRepository.GetGroupByPassenger(passengerId);
        }

        [HttpPost("sendMessage")]
        public Message SendMessage(Message message)
        {
            Group group = _groupRepository.GetGroupByPassenger(message.Passenger.Id);
            group.SendMessage(message);
            _groupRepository.SaveChanges();
            return message;
        }
    }
}