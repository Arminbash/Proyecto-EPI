using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_Services_TEAMCELL.Models;
using Api_Services_TEAMCELL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Api_Services_TEAMCELL.Methods;

namespace Api_Services_TEAMCELL.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [Route("getUsers")]
        public IActionResult getUsersActive()
        {
            var result = _userService.getUsersActive();
            return Ok(result);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult addUser([FromBody] tempUserModel tempUser)
        {
            var user = new User();
            user.UserName = tempUser.UserName;
            user.Salt = Cryptographic.GenerateSalt();
            user.Password = Cryptographic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(tempUser.Password), user.Salt);
            user.IdEmployee = tempUser.IdEmployee;
            user.Status = tempUser.Status;
            if (_userService.addUser(user))
                return Ok();
            else
                return BadRequest();
        }

        [Route("edit")]
        [HttpPut]
        public IActionResult editUser([FromBody] tempUserModel tempUser)
        {
            var user = new User();
            user.UserName = tempUser.UserName;
            user.Salt = Cryptographic.GenerateSalt();
            user.Password = Cryptographic.HashPasswordWithSalt(Encoding.UTF8.GetBytes(tempUser.Password), user.Salt);
            user.IdEmployee = tempUser.IdEmployee;
            user.Status = tempUser.Status;
            if (_userService.editUser(user))
                return Ok();
            else
                return BadRequest();
        }

        [Route("delete/{idUser}")]
        public IActionResult deleteUser(int idUser)
        {
            if (_userService.deleteUser(idUser))
                return Ok();
            else
                return BadRequest();
        }

        [Route("getUser/{iduUser}")]
        public IActionResult getUserXId(int iduUser)
        {
            return Ok(_userService.getUserXId(iduUser));
        }

        [Route("trylogin/{username}/{password}")]
        public IActionResult tryLogin(string username,string password)
        {
            if (_userService.tryLogin(username, password))
                return Ok();
            else
                return BadRequest();
        }

    }
    public class tempUserModel
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IdEmployee { get; set; }
        public Employee Employee { get; set; }
        public bool Status { get; set; }
    }
}