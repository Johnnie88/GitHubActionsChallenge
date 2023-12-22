using Microsoft.EntityFrameworkCore;
using GitHubActions.Domain.Entities;

namespace GitHubActions.Infrastructure
{
    public class CleanArchitectureDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public CleanArchitectureDbContext(DbContextOptions<CleanArchitectureDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Status> Status { get; set; }

    }
}
