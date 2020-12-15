using AutoMapper;
using Domain.DTO.Location.CEP;
using Domain.DTO.Location.Municipio;
using Domain.DTO.Location.UF;
using Domain.DTO.User;
using Domain.Entities;
using Domain.Entities.Location;

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

            CreateMap<UfDTO, UfEntity>()
                .ReverseMap();

            CreateMap<MunicipioCompletoDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioCreateDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipioUpdateResultDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<MunicipoCreateResultDTO, MunicipioEntity>()
                .ReverseMap();

            CreateMap<CepDTO, CepEntity>()
                .ReverseMap();

            CreateMap<CepCreateResultDTO, CepEntity>()
                .ReverseMap();
            
            CreateMap<CepUpdateResultDTO, CepEntity>()
                .ReverseMap();

        }
    }
}
