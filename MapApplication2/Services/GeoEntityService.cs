using Microsoft.EntityFrameworkCore;
using MapApplication2.Models;

namespace MapApplication2.Services
{
    public class GeoEntityService : IGeoEntityService
    {
        private readonly ApplicationDbContext _context;

        public GeoEntityService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<GeoEntity>> GetAllAsync()
        {
            return await _context.GeoEntities.ToListAsync();
        }

        public async Task<GeoEntity?> GetByIdAsync(int id)
        {
            return await _context.GeoEntities.FindAsync(id);
        }

        public async Task AddAsync(GeoEntity entity)
        {
            _context.GeoEntities.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(GeoEntity entity)
        {
            _context.GeoEntities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.GeoEntities.FindAsync(id);
            if (entity != null)
            {
                _context.GeoEntities.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
