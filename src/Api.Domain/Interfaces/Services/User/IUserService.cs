using Domain.DTO.User;
using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserDTO> Get(Guid id);
        Task<IEnumerable<UserDTO>> GetAll();
        Task<UserCreateResultDTO> Post(UserDTOCreate user);
        Task<UserUpdateResultDTO> Put(UserDTOUpdate user);
        Task<bool> Delete(Guid id);

    }
}
