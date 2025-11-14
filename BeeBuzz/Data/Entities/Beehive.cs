using System;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace BeeBuzz.Data.Entities
{
    public class Beehive
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public bool IsActive { get; set; } = true;

        public string? DeactivationReason { get; set; }

        public int UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
    }
}