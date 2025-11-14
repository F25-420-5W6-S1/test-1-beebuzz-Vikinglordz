using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data.Repositories
{
    public class BeehiveRepository : IBeehiveRepository
    {
        private readonly ApplicationDbContext _context;

        public BeehiveRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Beehive>> GetAllBeehivesAsync()
        {
            return await _context.Beehives
                .Include(beehive => beehive.User)
                .ToListAsync();
        }

        void IBeeBuzzGenericRepository<Beehive>.Add(Beehive entity)
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<Beehive>.Delete(Beehive entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Beehive> IBeeBuzzGenericRepository<Beehive>.GetAll()
        {
            throw new NotImplementedException();
        }

        Beehive IBeeBuzzGenericRepository<Beehive>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<Beehive>.SaveAll()
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<Beehive>.Update(Beehive entity)
        {
            throw new NotImplementedException();
        }
    }
}
