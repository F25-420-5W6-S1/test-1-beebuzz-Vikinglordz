using BeeBuzz.Data.Entities;
using BeeBuzz.Data.Interfaces;

namespace BeeBuzz.Data.Repositories
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly ApplicationDbContext _context;

        public OrganizationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        void IBeeBuzzGenericRepository<Organization>.Add(Organization entity)
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<Organization>.Delete(Organization entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Organization> IBeeBuzzGenericRepository<Organization>.GetAll()
        {
            throw new NotImplementedException();
        }

        Organization IBeeBuzzGenericRepository<Organization>.GetById(object id)
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<Organization>.SaveAll()
        {
            throw new NotImplementedException();
        }

        void IBeeBuzzGenericRepository<Organization>.Update(Organization entity)
        {
            throw new NotImplementedException();
        }
    }
}
