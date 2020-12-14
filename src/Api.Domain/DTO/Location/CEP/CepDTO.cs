using Domain.DTO.Location.Municipio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Location.CEP
{
    public class CepDTO
    {
        public Guid Id { get; set; } 
        public string Cep { get; set; }
        public string Logradouro { get; set;}
        public string Numero { get; set; }
        public Guid MunicipioID { get; set; }
        public MunicipioCompletoDTO Municipio { get; set; }
    }
}
