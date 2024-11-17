using JobVault.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobVault.Services
{
    public class VaultDbContext : DbContext
    {
        public VaultDbContext(DbContextOptions<VaultDbContext> option) : base(option) { }
        public DbSet<CandidateEntities> candidates { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CandidateEntities>(entity =>
            {
                entity.HasIndex(e => e.Email)
                    .IsUnique();
            });
        }
    }
}
