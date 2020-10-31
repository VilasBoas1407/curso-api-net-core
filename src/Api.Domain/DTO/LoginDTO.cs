using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO
{
    public class LoginDTO
    {   
        [Required(ErrorMessage ="Email é um campo obrigatório para Login!")]
        [EmailAddress(ErrorMessage ="E-mail inválido!")]
        [StringLength(100,ErrorMessage ="Email dever ter no máximo {1} caracteres!")]
        public string Email{ get; set; }
    }
}
