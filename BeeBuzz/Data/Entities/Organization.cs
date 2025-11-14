using System.ComponentModel.DataAnnotations;


namespace BeeBuzz.Data.Entities
{
    public class Organization
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string? Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();       
    }
}
