using System;
    

namespace Backend_Management.Models
{
    public class Patient
    {
        public string PatientId { get; set; }
        public string PatientGroupedId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastVisit { get; set; }
    }
}
