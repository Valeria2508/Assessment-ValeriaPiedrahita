using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_ValeriaPiedrahita.DTO;
using Assessment_ValeriaPiedrahita.DTO.Auth;
using Assessment_ValeriaPiedrahita.models;

namespace Assessment_ValeriaPiedrahita.repositories
{
    public interface IPatientRepositories
    {
        Task Add(Patient patient);

        Task<IEnumerable<PatientDTO>> GetAll();
        Task<PatientDTO> GetById(int id);
        Task<string> Login(LoginDTO login);
    }
}