using AutoMapper;
using Domain.DTO.Location.UF;
using Domain.Interfaces.Services.Location.UF;
using Domain.Repository.Location;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Location
{
    public class UfService : IUfService
    {

        private IUfRepository _repository;
        private readonly IMapper _mapper;

        public UfService(IUfRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UfDTO> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UfDTO>(entity);
        }

        public async Task<IEnumerable<UfDTO>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UfDTO>>(listEntity);
        }
    }
}
