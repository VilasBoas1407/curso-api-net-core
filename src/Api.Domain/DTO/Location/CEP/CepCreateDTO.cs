using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.DTO.Location.CEP
{
    public class CepCreateDTO
    {


        [Required(ErrorMessage = "CEP é um campo obrigatório!")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Logradouro é um campo obrigatório!")]
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        [Required(ErrorMessage = " Município é um campo obrigatório")]
        public Guid MunicipioId { get; set; }

    }
}
