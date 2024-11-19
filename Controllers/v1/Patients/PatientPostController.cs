using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.DTO;
using Assessment_ValeriaPiedrahita.models;
using Assessment_ValeriaPiedrahita.repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_ValeriaPiedrahita.Controllers.v1.Patients
{
    [ApiController]
    [Route("api/[controller]")]
    [Tags("patients")]
    public class PatientPostController : PatientController
    {
        public PatientPostController(IPatientRepositories patientRepositories) : base(patientRepositories)
        {
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> Post([FromBody] Patient patient)
        {
            await _patientRepositories.Add(patient);
            return Ok();
        }
    }
}