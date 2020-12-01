using AutoMapper;
using Domain.DTO.User;
using Domain.Models.User;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            CreateMap<UserModel, UserDTO>()
                .ReverseMap();
        }
    }
}
