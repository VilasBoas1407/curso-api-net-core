using Domain.DTO.Location.CEP;
using Domain.DTO.Location.Municipio;
using Domain.DTO.Location.UF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Test.CEP
{
    public class CepTestes
    {
        public static string CepOriginal { get; set; }
        public static string LogradouroOriginal { get; set; }
        public static string NumeroOriginal { get; set; }
        public static string CepAlterado { get; set; }
        public static string LogradouroAlterado { get; set; }
        public static string NumeroAlterado { get; set; }
        public static Guid IdMunicipio { get; set; }
        public static Guid IdCep { get; set; }

        public List<CepDTO> listaDto = new List<CepDTO>();
        public CepDTO cepDto;
        public CepCreateDTO cepDtoCreate;
        public CepCreateResultDTO cepDtoCreateResult;
        public CepUpdateDTO cepDtoUpdate;
        public CepUpdateResultDTO cepDtoUpdateResult;

        public CepTestes()
        {
            IdMunicipio = Guid.NewGuid();
            IdCep = Guid.NewGuid();
            CepOriginal = Faker.RandomNumber.Next(10000, 99999).ToString();
            NumeroOriginal = Faker.RandomNumber.Next(1, 1000).ToString();
            LogradouroOriginal = Faker.Address.StreetName();
            CepAlterado = Faker.RandomNumber.Next(10000, 99999).ToString();
            NumeroAlterado = Faker.RandomNumber.Next(1, 1000).ToString();
            LogradouroAlterado = Faker.Address.StreetName();

            for (int i = 0; i < 10; i++)
            {
                var dto = new CepDTO()
                {
                    Id = Guid.NewGuid(),
                    Cep = Faker.RandomNumber.Next(10000, 99999).ToString(),
                    Logradouro = Faker.Address.StreetName(),
                    Numero = Faker.RandomNumber.Next(1, 1000).ToString(),
                    MunicipioID = Guid.NewGuid(),
                    Municipio = new MunicipioCompletoDTO
                    {
                        Id = IdMunicipio,
                        Nome = Faker.Address.City(),
                        CodIBGE = Faker.RandomNumber.Next(1, 10000),
                        UfId = Guid.NewGuid(),
                        Uf = new UfDTO
                        {
                            Id = Guid.NewGuid(),
                            Nome = Faker.Address.UsState(),
                            Sigla = Faker.Address.UsState().Substring(1, 3)
                        }
                    }
                };
                listaDto.Add(dto);
            }

            cepDto = new CepDTO
            {
                Id = IdCep,
                Cep = CepOriginal,
                Logradouro = LogradouroOriginal,
                Numero = NumeroOriginal,
                MunicipioID = IdMunicipio,
                Municipio = new MunicipioCompletoDTO
                {
                    Id = IdMunicipio,
                    Nome = Faker.Address.City(),
                    CodIBGE = Faker.RandomNumber.Next(1, 10000),
                    UfId = Guid.NewGuid(),
                    Uf = new UfDTO
                    {
                        Id = Guid.NewGuid(),
                        Nome = Faker.Address.UsState(),
                        Sigla = Faker.Address.UsState().Substring(1, 3)
                    }
                }
            };

            cepDtoCreate = new CepCreateDTO
            {
                Cep = CepOriginal,
                Logradouro = LogradouroOriginal,
                Numero = NumeroOriginal,
                MunicipioId = IdMunicipio,
            };

            cepDtoCreateResult = new CepCreateResultDTO
            {
                Id = IdCep,
                Cep = CepOriginal,
                Logradouro = LogradouroOriginal,
                Numero = NumeroOriginal,
                MunicipioId = IdMunicipio,
                CreateAt = DateTime.UtcNow
            };

            cepDtoUpdate = new CepUpdateDTO
            {
                Id = IdCep,
                Cep = CepAlterado,
                Logradouro = LogradouroAlterado,
                Numero = NumeroAlterado,
                MunicipioId = IdMunicipio
            };

            cepDtoUpdateResult = new CepUpdateResultDTO
            {
                Id = IdMunicipio,
                Cep = CepAlterado,
                Logradouro = LogradouroAlterado,
                Numero = NumeroAlterado,
                MunicipioId = IdMunicipio,
                UpdateAt = DateTime.UtcNow
            };

        }
    }
}
