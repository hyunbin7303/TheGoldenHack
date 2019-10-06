using Backend_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Management
{
    public class HospitalContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {
        }
    }

}