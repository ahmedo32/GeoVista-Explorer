using MapApplication2.Models;

namespace MapApplication2.Unit
{
    public interface IUnitOfWork
    {
        IRepository<GeoEntity> GeoEntitiesRepository { get; }
        Task<int> CompleteAsync();
    }
}
