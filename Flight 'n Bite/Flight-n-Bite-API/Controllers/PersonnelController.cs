using System;
using System.Threading.Tasks;
using Flight_n_Bite_API.Model;
using Flight_n_Bite_API.Model.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Flight_n_Bite_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonnelController : ControllerBase
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IPersonnelRepository _personnelRepository;
        private readonly IConfiguration _config;



        public PersonnelController(
                 SignInManager<IdentityUser> signInManager,
                 UserManager<IdentityUser> userManager,
                 IPersonnelRepository personnelRepository,
                 IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _personnelRepository = personnelRepository;
            _config = config;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<ActionResult<Personnel>> logIn(PersonnelLoginDTO model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user != null)
            {
                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

                if (result.Succeeded)
                {
                    return _personnelRepository.GetPersonnel(model.UserName);
                }

            }
            return BadRequest();
        }

        
    }
}