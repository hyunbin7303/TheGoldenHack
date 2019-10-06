using System;
using Microsoft.EntityFrameworkCore;

namespace Backend_Management.Models
{
    public class UserAuthenticationContext : DbContext
    {
        public DbSet<Userauth> userauth  { get; set; }
        public UserAuthenticationContext(DbContextOptions<UserAuthenticationContext> options) : base(options)
        {

        }

        public string AuthenUser(string userId, string password)
        {
            string result = string.Empty;

            //checking from the user authentication database.

            return result;
        }
    }
}
