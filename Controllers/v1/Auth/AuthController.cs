using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.DTO.Auth;
using Assessment_ValeriaPiedrahita.repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_ValeriaPiedrahita.Controllers.v1.Auth
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        protected readonly IPatientRepositories _patientRepository;
        
        public AuthController(IPatientRepositories patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<string>> login( LoginDTO login)
        {
            var token = await _patientRepository.Login(login);
            return Ok($"Logged in successfully this is your token: {token}");
        }
    }
}