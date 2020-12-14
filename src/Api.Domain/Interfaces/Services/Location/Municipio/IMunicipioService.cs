using Domain.DTO.Location.Municipio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Location.Municipio
{
    public interface IMunicipioService
    {
        Task<MunicipioDTO> Get(Guid id);
        Task<MunicipioCompletoDTO> GetCompleteById(Guid id);
        Task<MunicipioCompletoDTO> GetCompleteByIBGE(int codIBGE);
        Task<IEnumerable<MunicipioDTO>> GetAll();
        Task<MunicipoCreateResultDTO> Post(MunicipioCreateDTO municipio);
        Task<MunicipioUpdateResultDTO> Put(MunicipioUpdateDTO municipio);
        Task<bool> Delete(Guid id);
    }
}
