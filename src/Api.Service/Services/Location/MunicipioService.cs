using AutoMapper;
using Domain.DTO.Location.Municipio;
using Domain.Entities.Location;
using Domain.Interfaces.Services.Location.Municipio;
using Domain.Models.Location;
using Domain.Repository.Location;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services.Location
{
    public class MunicipioService : IMunicipioService
    {
        private IMunicipioRepository _repository;
        private readonly IMapper _mapper;

        public MunicipioService(IMunicipioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<MunicipioDTO> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<MunicipioDTO>(entity);
        }

        public async Task<IEnumerable<MunicipioDTO>> GetAll()
        {
            var entity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<MunicipioDTO>>(entity);
        }

        public async Task<MunicipioCompletoDTO> GetCompleteByIBGE(int codIBGE)
        {
            var entity = await _repository.GetCompleteByIBGE(codIBGE);
            return _mapper.Map<MunicipioCompletoDTO>(entity);
        }

        public async Task<MunicipioCompletoDTO> GetCompleteById(Guid id)
        {
            var entity = await _repository.GetCompleteById(id);
            return _mapper.Map<MunicipioCompletoDTO>(entity);
        }

        public async Task<MunicipoCreateResultDTO> Post(MunicipioCreateDTO municipio)
        {
            var model = _mapper.Map<MunicipioModel>(municipio);
            var entity = _mapper.Map<MunicipioEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<MunicipoCreateResultDTO>(result);
        }

        public async Task<MunicipioUpdateResultDTO> Put(MunicipioUpdateDTO municipio)
        {
            var model = _mapper.Map<MunicipioModel>(municipio);
            var entity = _mapper.Map<MunicipioEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<MunicipioUpdateResultDTO>(result);
        }
    }
}
