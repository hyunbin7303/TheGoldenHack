using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Backend_Management.Models
{
    public class AuthenticationContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<UserAuthen> userAuthen { get; set; }

        public AuthenticationContext(DbContextOptions<AuthenticationContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseNpgsql("Host=my_host;Database=my_db;Username=my_user;Password=my_pw");

        public string PassingUserInfo(string id, string password)
        {

            return "hey";
        }
        public string userToken()
        {
            return "HAHA";
        }
    }
}
