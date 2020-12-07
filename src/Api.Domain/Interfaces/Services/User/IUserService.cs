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
        Task<UserCreateResultDTO> Post(UserDTO user);
        Task<UserUpdateResultDTO> Put(UserDTO user);
        Task<bool> Delete(Guid id);

    }
}
