using System;

namespace Domain.Entities.Location
{
    public class MunicipioEntity : BaseEntity
    {
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public UfEntity Uf { get; set; }
    }
}
