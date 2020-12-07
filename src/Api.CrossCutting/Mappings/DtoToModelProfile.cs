using AutoMapper;
using Domain.DTO.User;
using Domain.Models.User;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDTO>().ReverseMap();

            CreateMap<UserModel, UserDTOCreate>().ReverseMap();

            CreateMap<UserModel, UserDTOUpdate>().ReverseMap();
        }
    }
}
