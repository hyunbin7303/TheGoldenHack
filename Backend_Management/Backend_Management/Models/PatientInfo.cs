using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Management.Models
{
    public class PatientInfo
    {
        public string patientId { get; set; }
        public string PatientGroupedId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime lastVisit { get; set; }
        public string DetailInfo { get; set; }
    }
}
