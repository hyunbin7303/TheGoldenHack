using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Management.Models
{
    public static class SeedData
    {
        public static void Hospital_Seed(HospitalContext context)
        {
            if (context.Patient.Any())
                return;   // DB has been seeded
            context.Patient.AddRange(
            new Patient
            {
                PatientId = Guid.NewGuid().ToString(),
                PatientGroupId = "e985d0e1-c62e-434f-942d-524325bbe517",
                FirstName = "Kevin",
                LastName = "Park",
                LastVisit = DateTime.Today
            },
            new Patient
        {
            PatientId = Guid.NewGuid().ToString(),
            PatientGroupId = "e985d0e1-c62e-434f-942d-524325bbe517",
            FirstName = "Habib",
            LastName = "Shakibanejad",
            LastVisit = DateTime.Today
        },
            new Patient
        {
            PatientId = Guid.NewGuid().ToString(),
            PatientGroupId = "e985d0e1-c62e-434f-942d-524325bbe517",
            FirstName = "Julio",
            LastName = "Rivas",
            LastVisit = DateTime.Today
        },
            new Patient
            {
                PatientId = Guid.NewGuid().ToString(),
                PatientGroupId = "668be104-42d9-404e-a18e-1995305df863",
                FirstName = "Adam",
                LastName = "Sosnowski",
                LastVisit = DateTime.Today
            },
            new Patient
            {
                PatientId = Guid.NewGuid().ToString(),
                PatientGroupId = "668be104-42d9-404e-a18e-1995305df863",
                FirstName = "Julio",
                LastName = "Rivas",
                LastVisit = DateTime.Today
            },
            new Patient
            {
                PatientId = Guid.NewGuid().ToString(),
                PatientGroupId = "668be104-42d9-404e-a18e-1995305df863",
                FirstName = "Julio",
                LastName = "Rivas",
                LastVisit = DateTime.Today
            },
            new Patient
            {
                PatientId = Guid.NewGuid().ToString(),
                PatientGroupId = "a93ed7db-f1d5-4998-96ba-500c40427150",
                FirstName = "show",
                LastName = "whoyouare",
                LastVisit = DateTime.Today
            });
            context.SaveChanges();
        }
        public static void User_Seed(UserAuthenticationContext context)
        {
            if (context.Users.Any())
            {
                return;   // DB has been seeded
            }
            context.Users.AddRange(
            new User
            {
                UserId = "Nurse01234",
                UseraccessId = "e985d0e1-c62e-434f-942d-524325bbe517",
                Password = "12345"
            },
            new User
            {
                UserId = "Nurse9999",
                UseraccessId = "668be104-42d9-404e-a18e-1995305df863",
                Password = "67890"
            },
            new User
            {
                UserId = "Nurse5555",
                UseraccessId = "a93ed7db-f1d5-4998-96ba-500c40427150",
                Password = "54321"
            });
            context.SaveChanges();
        }
        public static void Userauth_Seed(UserAuthenticationContext context)
        {
            if (context.userauth.Any())
                return;
            context.Users.AddRange();

        }
    }
}
