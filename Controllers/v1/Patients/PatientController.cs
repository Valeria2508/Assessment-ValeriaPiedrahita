using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_ValeriaPiedrahita.Controllers.v1.Patients
{
    [ApiController]
    [Route("api/v1/Patients")]
    public class PatientController : ControllerBase
    {
        protected readonly IPatientRepositories _patientRepositories;
        
        public PatientController(IPatientRepositories patientRepositories)
        {
            _patientRepositories = patientRepositories;
        }
    }
}