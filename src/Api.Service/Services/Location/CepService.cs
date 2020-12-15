using AutoMapper;
using Domain.DTO.Location.CEP;
using Domain.Entities.Location;
using Domain.Interfaces.Services.Location.CEP;
using Domain.Models.Location;
using Domain.Repository.Location;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Location
{
    public class CepService : ICepService
    {
        private ICepRepository _repository;
        private readonly IMapper _mapper;

        public CepService(ICepRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<CepDTO> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<CepDTO>(entity);
        }

        public async Task<CepDTO> Get(string cep)
        {
            var entity = await _repository.SelectAsync(cep);
            return _mapper.Map<CepDTO>(entity);
        }

        public async Task<CepCreateResultDTO> Post(CepCreateDTO cep)
        {
            var model = _mapper.Map<CepModel>(cep);
            var entity = _mapper.Map<CepEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<CepCreateResultDTO>(result);
        }

        public async Task<CepUpdateResultDTO> Put(CepUpdateDTO cep)
        {
            var model = _mapper.Map<CepModel>(cep);
            var entity = _mapper.Map<CepEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<CepUpdateResultDTO>(result);
        }
    }
}
