using Domain.Entities.Location;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace Domain.Repository.Location
{
    public interface ICepRepository : IRepository<CepEntity>
    {
        Task<CepEntity> SelectAsync(string cep);
    }
}
