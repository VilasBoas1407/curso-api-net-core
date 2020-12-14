using System;

namespace Domain.DTO.Location.Municipio
{
    public class MunicipioCreateDTO
    {
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
    }
}
