using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO.User
{
    public class UserDTOUpdate
    {
        [Required (ErrorMessage ="GUID é uma campo obrigatório!")]
        public Guid id { get; set; }

        [Required(ErrorMessage ="Nome é um campo obrigatório!")]
        [StringLength(60,ErrorMessage ="Nome deve ter no máximo {1} caracteres!")]
        public string Name { get; set; }

        [Required(ErrorMessage ="E-mail é um campo obrigatório!")]
        [EmailAddress (ErrorMessage ="E-mail em formato inválido!")]
        [StringLength(160, ErrorMessage = "E-mail deve ter no máximo {1} caracteres!")]
        public string Email{ get; set; }
    }
}
