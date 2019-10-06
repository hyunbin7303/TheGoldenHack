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
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly UserAuthenticationContext _context;

        //[HttpPost]
        //public string Post([FromBody]User value)
        //{
        //    if (_context.Users.Any(user => user.UserId.Equals(value.UserId)))
        //    {
        //        User user = _context.Users.Where(u => u.UserId.Equals(value.UserId)).First();
        //        var client_post_hash_password = Convert.ToBase64String(
        //            Hashing.SaltHashPassword(Encoding.ASCII.GetBytes(value.Password),
        //                                    Convert.FromBase64String(user.Salt)));
        //        if (client_post_hash_password.Equals(user.Password))
        //            return JsonConvert.SerializeObject(user);
        //        else
        //        {
        //            return JsonConvert.SerializeObject("Wrong Password");
        //        }
        //    }
        //    else
        //    {
        //        return JsonConvert.SerializeObject("User is existing in the database.");
        //    }
        //}


        [HttpPost]
        public string Post([FromBody]User value)
        {
            if(_context.Users.Any(user => user.UserId.Equals(value.UserId)))
            {
                 User user = _context.Users.Where(u => u.UserId.Equals(value.UserId)).First();
                 if(user.Password.Equals(value.Password))
                {                    
                    return JsonConvert.SerializeObject(user);
                }
                else
                {
                    return JsonConvert.SerializeObject("Wrong password.");
                }
            }
            else
            {
                return JsonConvert.SerializeObject("User Doesn't exist.");
            }
        }
    }
}