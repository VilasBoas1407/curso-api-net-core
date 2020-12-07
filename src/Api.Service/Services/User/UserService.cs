using AutoMapper;
using Domain.DTO.User;
using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Services.User;
using Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Services
{
    public class UserService : IUserService
    {
        private IRepository<UserEntity> _repository;
        private readonly IMapper _mapper;
        
        public UserService(IRepository<UserEntity> repository,IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UserDTO> Get(Guid id)
        {
            var entity =  await _repository.SelectAsync(id);
            return _mapper.Map<UserDTO>(entity);
        }

        public async Task<IEnumerable<UserDTO>> GetAll()
        {
            var listUsers = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UserDTO>>(listUsers);
        }

        public async Task<UserCreateResultDTO> Post(UserDTOCreate user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<UserCreateResultDTO>(result);

        }

        public async Task<UserUpdateResultDTO> Put(UserDTOUpdate user)
        {
            var model = _mapper.Map<UserModel>(user);
            var entity = _mapper.Map<UserEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<UserUpdateResultDTO>(result);
        }
    }
}
