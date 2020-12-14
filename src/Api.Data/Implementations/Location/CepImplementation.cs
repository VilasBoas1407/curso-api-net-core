using Data.Context;
using Data.Repository;
using Domain.Entities;
using Domain.Entities.Location;
using Domain.Repository.Location;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations.Location
{
    public class CepImplementation : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _dataset;

        public CepImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CepEntity>();
        }

        public async Task<CepEntity> SelectAsync(string cep)
        {
            return await _dataset.Include(c => c.Municipio)
                                    .ThenInclude(m => m.Uf)
                                    .FirstOrDefaultAsync(u => u.Cep.Equals(cep));

        }
    }
}
