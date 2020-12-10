using Domain.DTO.User;
using System;
using System.Collections.Generic;

namespace Api.Service.Test.User
{
    public class UserTest
    {
        public static string  NomeUsuario{ get; set; }

        public static string EmailUsuario { get; set; }

        public static string NomeUsuarioAlterado { get; set; }

        public static string EmailUsuarioAlterado { get; set; }

        public static Guid IdUsuario { get; set; }

        public List<UserDTO> listaUserDto = new List<UserDTO>();

        public UserDTO userDto;

        public UserDTOCreate userDTOCreate;

        public UserCreateResultDTO userCreateResult;

        public UserDTOUpdate userDTOUpdate;

        public UserUpdateResultDTO userUpdateResult;

        public UserTest()
        {
            IdUsuario = Guid.NewGuid();
            NomeUsuario = Faker.Name.FullName();
            EmailUsuario = Faker.Internet.Email();
            NomeUsuarioAlterado = Faker.Name.FullName();
            EmailUsuarioAlterado = Faker.Internet.Email();

            for (int i = 0; i < 10; i++)
            {
                var dto = new UserDTO()
                {
                    Id = Guid.NewGuid(),
                    Name = Faker.Name.FullName(),
                    Email = Faker.Internet.Email()
                };

                listaUserDto.Add(dto);
            }

            userDto = new UserDTO
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            userDTOCreate = new UserDTOCreate
            {
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            userCreateResult = new UserCreateResultDTO
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario,
                CreateAt = DateTime.UtcNow
            };

            userDTOUpdate= new UserDTOUpdate
            {
                id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario
            };

            userUpdateResult = new UserUpdateResultDTO
            {
                Id = IdUsuario,
                Name = NomeUsuario,
                Email = EmailUsuario,
                UpdateAt = DateTime.UtcNow
            };
        }

    }
}
