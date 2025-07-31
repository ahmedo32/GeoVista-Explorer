using MapApplication2.Models;
using MapApplication2.Services;
using System.Threading.Tasks;

namespace MapApplication2.Unit
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IRepository<GeoEntity> GeoEntitiesRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext context, IRepository<GeoEntity> geoEntitiesRepository)
        {
            _context = context;
            GeoEntitiesRepository = geoEntitiesRepository;
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
