using Domain.DTO.Location.Municipio;
using Domain.DTO.Location.UF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Test.Municipio
{
    public class MunicipioTestes
    {
        public static string NomeMunicipio { get; set; }
        public static int CodigoIBGEMunicipio { get; set; }
        public static string NomeMunicipioAlterado { get; set; }
        public static int CodigoIBGEMunicipioAlterado { get; set; }
        public static Guid IdMunicipio { get; set; }
        public static Guid IdUf { get; set; }

        public List<MunicipioDTO> listaDto = new List<MunicipioDTO>();
        public MunicipioDTO municipioDto;
        public MunicipioCompletoDTO municipioDtoCompleto;
        public MunicipioCreateDTO municipioDtoCreate;
        public MunicipoCreateResultDTO municipioDtoCreateResult;
        public MunicipioUpdateDTO municipioDtoUpdate;
        public MunicipioUpdateResultDTO municipioDtoUpdateResult;

        public MunicipioTestes()
        {
            IdMunicipio = Guid.NewGuid();
            NomeMunicipio = Faker.Address.StreetName();
            CodigoIBGEMunicipio = Faker.RandomNumber.Next(1, 10000);
            NomeMunicipioAlterado = Faker.Address.StreetName();
            CodigoIBGEMunicipioAlterado = Faker.RandomNumber.Next(1, 10000);
            IdUf = Guid.NewGuid();

            for (int i = 0; i < 10; i++)
            {
                var dto = new MunicipioDTO()
                {
                    Id = Guid.NewGuid(),
                    Nome = Faker.Name.FullName(),
                    CodIBGE = Faker.RandomNumber.Next(1, 10000),
                    UfId = Guid.NewGuid()
                };
                listaDto.Add(dto);
            }

            municipioDto = new MunicipioDTO
            {
                Id = IdMunicipio,
                Nome = NomeMunicipio,
                CodIBGE = CodigoIBGEMunicipio,
                UfId = IdUf
            };

            municipioDtoCompleto = new MunicipioCompletoDTO
            {
                Id = IdMunicipio,
                Nome = NomeMunicipio,
                CodIBGE = CodigoIBGEMunicipio,
                UfId = IdUf,
                Uf = new UfDTO
                {
                    Id = Guid.NewGuid(),
                    Nome = Faker.Address.UsState(),
                    Sigla = Faker.Address.UsState().Substring(1, 3)
                }
            };

            municipioDtoCreate = new MunicipioCreateDTO
            {
                Nome = NomeMunicipio,
                CodIBGE = CodigoIBGEMunicipio,
                UfId = IdUf
            };

            municipioDtoCreateResult = new MunicipoCreateResultDTO
            {
                Id = IdMunicipio,
                Nome = NomeMunicipio,
                CodIBGE = CodigoIBGEMunicipio,
                UfId = IdUf,
                CreateAt = DateTime.UtcNow
            };

            municipioDtoUpdate = new MunicipioUpdateDTO
            {
                Id = IdMunicipio,
                Nome = NomeMunicipioAlterado,
                CodIBGE = CodigoIBGEMunicipioAlterado,
                UfId = IdUf
            };

            municipioDtoUpdateResult = new MunicipioUpdateResultDTO
            {
                Id = IdMunicipio,
                Nome = NomeMunicipioAlterado,
                CodIBGE = CodigoIBGEMunicipioAlterado,
                UfId = IdUf,
                UpdateAt = DateTime.UtcNow
            };

        }
    }
}
