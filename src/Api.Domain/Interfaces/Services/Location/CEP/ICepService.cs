using Domain.DTO.Location.CEP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Location.CEP
{
    public interface ICepService
    {
        Task<CepDTO> Get(Guid id);
        Task<CepDTO> Get(string cep);
        Task<CepCreateResultDTO> Post(CepCreateDTO cep);
        Task<CepUpdateResultDTO> Put(CepUpdateDTO cep);
        Task<bool> Delete(Guid id);
    }
}
