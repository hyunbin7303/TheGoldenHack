using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Backend_Management.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly HospitalContext _hospitalContext;
        private static bool onOff = false;
        public HospitalController(HospitalContext hospitalContext)
        {
            _hospitalContext = hospitalContext;
            if(!onOff)
            {
                SeedData.Hospital_Seed(hospitalContext);
                onOff = true;
            }

        }
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            var patient = _hospitalContext.Patient.ToList();
            return patient;
        }

        [HttpGet]
        [Route("GetPatients/{_groupid}")]
        public IEnumerable<Patient> GetByLocationid(string _groupid)
        {
            IEnumerable<Patient> patients = new List<Patient>();
            if (_hospitalContext.Patient.Any(p => p.PatientGroupedId.Equals(_groupid)))
            {

                patients = from b in _hospitalContext.Patient
                            where b.PatientGroupedId.Equals(_groupid)
                            select b;
            }
            else
            {
                return null;
            }
            return patients;

        }


    }
}