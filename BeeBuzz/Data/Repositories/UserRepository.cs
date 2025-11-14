using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await _context.Users
                .Include(user => user.Organization)
                .ToListAsync();
        }

        void IBeeBuzzGenericRepository<ApplicationUser>.Add(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<ApplicationUser>.Delete(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<ApplicationUser> IBeeBuzzGenericRepository<ApplicationUser>.GetAll()
        {
            throw new NotImplementedException();
        }

        ApplicationUser IBeeBuzzGenericRepository<ApplicationUser>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<ApplicationUser>.SaveAll()
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<ApplicationUser>.Update(ApplicationUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
