using Microsoft.EntityFrameworkCore;
using RackSwip.Data;
using RackSwip.Interfaces;
using RackSwip.Models;

namespace RackSwip.Repository
{
    public class EdificioRepository : IEdificioRepository
    {
        private readonly ApplicationDbContext _context;

        public EdificioRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool Add(Edificio edificio)
        {
            _context.Edificios.Add(edificio);
            return Save();
        }

        public bool Delete(Edificio edificio)
        {
            _context.Edificios.Remove(edificio);
            return Save();
        }

        public async Task<IEnumerable<Edificio>> GetAllEdificios()
        {
            return await _context.Edificios
                            .Include(e => e.Sides)
                            .ToListAsync();
        }

        public async Task<Edificio> GetByIdAsync(int id)
        {
            return await _context.Edificios.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Edificio> GetByIdAsyncNoTracking(int id)
        {
            return await _context.Edificios.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }

        public bool Update(Edificio edificio)
        {
            _context.Edificios.Update(edificio);
            return Save();
        }
    }
}
