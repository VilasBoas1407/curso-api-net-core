using AutoMapper;
using Domain.DTO.Location.CEP;
using Domain.DTO.Location.Municipio;
using Domain.DTO.Location.UF;
using Domain.DTO.User;
using Domain.Models.Location;
using Domain.Models.User;

namespace CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region User
            
            CreateMap<UserModel, UserDTO>()
                .ReverseMap();

            CreateMap<UserModel, UserDTOCreate>()
                .ReverseMap();

            CreateMap<UserModel, UserDTOUpdate>()
                .ReverseMap();

            #endregion

            #region UF

            CreateMap<UfModel, UfDTO>()
                .ReverseMap();

            #endregion

            #region Município

            CreateMap<MunicipioModel, MunicipioDTO>()
                .ReverseMap();

            CreateMap<MunicipioModel, MunicipioCreateDTO>()
                .ReverseMap();

            CreateMap<MunicipioModel, MunicipioUpdateDTO>()
                .ReverseMap();

            #endregion

            #region CEP

            CreateMap<CepModel, CepDTO>()
                .ReverseMap();

            CreateMap<CepModel, CepUpdateDTO>()
                .ReverseMap();
            
            CreateMap<CepModel, CepCreateDTO>()
                .ReverseMap();

            #endregion
        }
    }
}
