using Microsoft.AspNetCore.Identity;

namespace BeeBuzz.Data.Entities
{
public class ApplicationUser : IdentityUser<int>
    {
        public Guid OrganizationId { get; set; } // Foreign key to Organization

        public Organization Organization { get; set; } = null!;

        public ICollection<Beehive> Beehives { get; set; } = new List<Beehive>();
    }
}