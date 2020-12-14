using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.DTO.Location.Municipio
{
    public class MunicipioCreateDTO
    {
        [Required(ErrorMessage ="Nome de Município é um campo obrigatório!")]
        [StringLength(60,ErrorMessage ="Nome de Município deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }
        [Range(0, int.MaxValue,ErrorMessage ="Código IBGE inválido")]
        public int CodIBGE { get; set; }
        [Required(ErrorMessage = "Código de UF é um campo obrigatório")]
        public Guid UfId { get; set; }
    }
}
