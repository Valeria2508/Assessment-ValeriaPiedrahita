using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.config;
using Assessment_ValeriaPiedrahita.data;
using Assessment_ValeriaPiedrahita.DTO;
using Assessment_ValeriaPiedrahita.DTO.Auth;
using Assessment_ValeriaPiedrahita.models;
using Assessment_ValeriaPiedrahita.repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_ValeriaPiedrahita.services
{
    public class PatientsServices : IPatientRepositories
    {
        protected readonly AppDbContext _context;
        private readonly Utilities _utilities;

        public PatientsServices(AppDbContext context, Utilities utilities)
        {
            _context = context;
            _utilities = utilities;
        }

        public async Task Add(Patient patient)
        {
            patient.Password=_utilities.EncryptSHA256(patient.Password);
            var patient1 = new Patient
            {
                Id = patient.Id,
                First_Name = patient.First_Name,
                Last_Name = patient.Last_Name,
                Email = patient.Email,
                Password = patient.Password,
                DateOfBirth = patient.DateOfBirth,
                IdentificationNumber = patient.IdentificationNumber,
            };
            _context.Patients.Add(patient1);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PatientDTO>> GetAll()
        {
            var patient = await _context.Patients.Select(patient => new PatientDTO
            {
                Id = patient.Id,
                FirstName = patient.First_Name,
                LastName = patient.Last_Name,
                Email = patient.Email,
                IdentificationNumber = patient.IdentificationNumber,
                Password = patient.Password
            }).ToListAsync();
            return patient;
        }


        public async Task<PatientDTO> GetById(int id)
        {
            var patient = await _context.Patients.Where(p => p.Id == id).Select(c => new PatientDTO
            {
                Id = c.Id,
                FirstName = c.First_Name,
                LastName = c.Last_Name,
                Email = c.Email,
                IdentificationNumber = c.IdentificationNumber,
                Password = c.Password
            }).FirstOrDefaultAsync();
            return patient;
        }

        public async Task<string> Login(LoginDTO login)
        {
            var user1 = await _context.Patients.FirstOrDefaultAsync(u => u.Email == login.Email);

            if (user1 != null)
            {
                if (user1.Password == _utilities.EncryptSHA256(login.Password)) //validate the password that is the same as the hashed password
                {
                    var token = _utilities.GenerateJwtToken(user1);
                    return token;
                }
                return "invalid user or password";
            }
            return "invalid user or password";
        }

    }
}