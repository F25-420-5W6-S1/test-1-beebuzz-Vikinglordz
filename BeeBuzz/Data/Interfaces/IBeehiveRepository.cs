using BeeBuzz.Data.Entities;

namespace BeeBuzz.Data.Interfaces
{
    public interface IBeehiveRepository : IBeeBuzzGenericRepository<Beehive>
    {
        Task<IEnumerable<Beehive>> GetAllBeehivesAsync();
    }
}
