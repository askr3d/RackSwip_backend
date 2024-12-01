using RackSwip.Models;

namespace RackSwip.Interfaces
{
    public interface IEdificioRepository
    {
        Task<Edificio> GetByIdAsync(int id);
        Task<Edificio> GetByIdAsyncNoTracking(int id);
        Task<IEnumerable<Edificio>> GetAllEdificios();
        bool Add(Edificio edificio);
        bool Update(Edificio edificio);
        bool Delete(Edificio edificio);
        bool Save();

    }
}
