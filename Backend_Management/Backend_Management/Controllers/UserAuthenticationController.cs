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
    public class UserAuthenticationController : Controller
    {
        private readonly AuthenticationContext _context;
        public UserAuthenticationController(AuthenticationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IEnumerable<UserAuthen> Post(string _id, string _password)
        {
            var test = _context.PassingUserInfo(_id, _password);
            return null;
        }


        // for now, it's  testing purpose.
        [HttpGet]
        public IEnumerable<UserAuthen> Get()
        {
            return _context.userToken;
        }
    }
}