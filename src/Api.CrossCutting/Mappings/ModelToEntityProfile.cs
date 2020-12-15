using AutoMapper;
using Domain.Entities;
using Domain.Entities.Location;
using Domain.Models.Location;
using Domain.Models.User;

namespace CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserEntity, UserModel>()
                .ReverseMap();

            CreateMap<UfModel, UfEntity>()
                .ReverseMap();

            CreateMap<MunicipioModel, MunicipioEntity>()
                .ReverseMap();

            CreateMap<CepModel, CepEntity>()
                .ReverseMap();


        }
    }
}
