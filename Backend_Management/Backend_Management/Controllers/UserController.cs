using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Backend_Management.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserAuthenticationContext _context;




        // This post request is used for registering.
        [HttpPost]
        public string Post([FromBody]User _user)
        {

            if (!_context.Users.Any(user => user.UserId.Equals(_user.UserId)))
            {
                User user = new User();
                user.UserId = _user.UserId;
                user.Salt = Convert.ToBase64String(Hashing.GetRandomSalt(16));
                user.Password = Convert.ToBase64String(Hashing.SaltHashPassword(
                    Encoding.ASCII.GetBytes(_user.Password),
                    Convert.FromBase64String(user.Salt)));
                // add to db
                try
                {
                    _context.Add(user);
                    _context.SaveChanges();
                    return JsonConvert.SerializeObject("REGISTER COMPLETE");
                }
                catch (Exception ex)
                {
                    return JsonConvert.SerializeObject(ex.Message);
                }

            }
            else
            {
                return JsonConvert.SerializeObject("User is existing in the database.");
            }
        }
    }
}