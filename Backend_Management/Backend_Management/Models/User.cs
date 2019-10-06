using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Management.Models
{
    public class User // nurses
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string UseraccessId { get; set; }
        public string Salt { get; set; }

    }
}
