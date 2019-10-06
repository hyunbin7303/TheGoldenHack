using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend_Management.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
                SeedData.User_Seed(hospitalContext);
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
    }
}