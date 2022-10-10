using Business.Abstract;
using Entities.DTO;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace TodoAppBackEnd.Controllers
{
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("CreateUser")]
        public IActionResult Add([FromBody]UserForRegisterDto user)
        {
            var userId = this.User.Identity.GetUserId();
            var result = _userService.Add(user, userId);
            if (result)
            {
                return Ok();
            }
            return NotFound();
        }
        [HttpGet("GetUser")]
        public IActionResult Get([FromBody]long id)
        {
            var result = _userService.Get(id);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("GetUserByUsername/{userName}")]
        public IActionResult GetUserByUsername(string userName)
        {
            var result = _userService.GetByUsername(userName);
            if(result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("GetAllUser")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound();
        }
        [HttpPut("UpdateUser")]
        public IActionResult Update([FromQuery] long id, [FromBody] UserForLoginDto user)
        {

            var result = _userService.Update(id, user);

            if (result)
            {
                return Ok();
            }
            return BadRequest();

        }
        [HttpDelete("DeleteUser")]
        public IActionResult Delete([FromQuery] int id)
        {

            var result = _userService.Delete(id);
            if (result)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
