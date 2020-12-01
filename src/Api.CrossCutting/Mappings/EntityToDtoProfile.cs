using AutoMapper;
using Domain.DTO.User;
using Domain.Entities;

namespace CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile 
    {
        public EntityToDtoProfile()
        {
            CreateMap<UserDTO, UserEntity>()
                .ReverseMap();

            CreateMap<UserCreateResultDTO, UserEntity>()
                .ReverseMap();

            CreateMap<UserUpdateResultDTO, UserEntity>()
                .ReverseMap();
        }
    }
}
