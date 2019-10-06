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
            SeedData.User_Seed(context);
            SeedData.Userauth_Seed(context);
        }

        // getting from the user input.
        [HttpPost]
        public IEnumerable<Userauth> Post([FromBody]User user)
        {
            var test = _context.AuthenUser(user.UserId, user.Password);
            //e985d0e1-c62e-434f-942d-524325bbe517
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