using Domain.DTO.Location.UF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Location.UF
{
    public interface IUfService
    {
        Task<UfDTO> Get(Guid id);
        Task<IEnumerable<UfDTO>> GetAll();
    }
}
