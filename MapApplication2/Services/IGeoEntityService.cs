using MapApplication2.Models;

namespace MapApplication2.Services
{
    public interface IGeoEntityService
    {
        Task<IEnumerable<GeoEntity>> GetAllAsync();
        Task<GeoEntity?> GetByIdAsync(int id);
        Task AddAsync(GeoEntity entity);
        Task UpdateAsync(GeoEntity entity);
        Task DeleteAsync(int id);
    }
}
