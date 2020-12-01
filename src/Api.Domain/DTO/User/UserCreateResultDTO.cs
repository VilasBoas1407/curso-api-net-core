using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.User
{
    public class UserCreateResultDTO
    {
        public Guid Id{ get; set; }
        public string Name{ get; set; }
        public string Email{ get; set; }
        public DateTime CreateAt { get; set; }
    }
}
