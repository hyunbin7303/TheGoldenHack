using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Management.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthenController : ControllerBase
    {
        private readonly UserAuthenticationContext _context;
        public AuthenController(UserAuthenticationContext context){
            _context = context;
        }



        // getting from the user input.
        [HttpPost]
        public IEnumerable<Userauth> Post([FromBody]User user)
        {
            //var test = _context.PassingUserInfo(_id, _password);
            return null;
        }

        [HttpGet]
        public IEnumerable<Userauth> Get()
        {
            var check = _context.userauth.ToList();
            return check;
        }
    }
}