using idflNet.auth;
using idflNet.Core.Dtos;
using idflNet.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Controllers.common
{
    [ApiController]
    [Authorize]
    [Route("api/authenticate")]
    public class AuthenticateController : ControllerBase
    {
        private IUserRepository _userService;
        public AuthenticateController(IUserRepository userService)
        {
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate([FromBody] AuthenticateRequestDto model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}