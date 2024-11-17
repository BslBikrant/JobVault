using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace JobVault.Entities
{
    public class CandidateEntities
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; } 
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = string.Empty;
        public int? TimeInterval { get; set; }
        public string? LinkedProfile { get; set; } = string.Empty;
        public string? GithubProfile { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
