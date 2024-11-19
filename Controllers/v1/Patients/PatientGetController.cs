using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.DTO;
using Assessment_ValeriaPiedrahita.models;
using Assessment_ValeriaPiedrahita.repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Assessment_ValeriaPiedrahita.Controllers.v1.Patients
{
    [ApiController]
    [Route("api/[controller]")]
    [Tags("patients")]
    public class PatientGetController : PatientController
    {
        public PatientGetController(IPatientRepositories patientRepositories) : base(patientRepositories)
        {
        }
        [HttpGet]
        [SwaggerOperation(
          Summary = "Get patient",
          Description = "Returns all the patients in database")]
        [SwaggerResponse(200, "Ok: returns all the patients in database")]
        [SwaggerResponse(204, "No Content: there are not patients in the database")]
        

        public async Task<ActionResult<List<Patient>>> GetPatients()
        {
            var patients = await _patientRepositories.GetAll();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        [Authorize]
        [SwaggerOperation(
          Summary = "Get patient by id",
          Description = "Returns by id the patients in database")]
        [SwaggerResponse(200, "Ok: returns by id the patients in database")]
        [SwaggerResponse(204, "No Content: there are not patients in the database")]
        
        public async Task<ActionResult<Patient>> GetPatientById(int id)
        {
            var patient = await _patientRepositories.GetById(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

  

    }
}