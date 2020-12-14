using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTO.Location.Municipio
{
    public class MunicipioUpdateResultDTO
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
