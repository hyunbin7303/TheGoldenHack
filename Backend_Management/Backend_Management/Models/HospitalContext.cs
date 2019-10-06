using Backend_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Management
{
    public class HospitalContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }


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