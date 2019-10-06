using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Management.Models
{
    public class Userauth
    {
        [Key]
        public string UseraccessId { get; set; }
        public string AccessCode { get; set; }

    }
}
