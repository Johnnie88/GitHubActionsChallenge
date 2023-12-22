using Microsoft.EntityFrameworkCore;
using GitHubActions.Domain.Entities;
using GitHubActions.Domain.Interfaces;
using System.Threading.Tasks;

namespace GitHubActions.Infrastructure.Repositories
{
    public class StatusRepository : IStatusRepository
    {
        private readonly CleanArchitectureDbContext _cleanArchitectureDbContext;

        public StatusRepository(CleanArchitectureDbContext cleanArchitectureDbContext)
        {
            _cleanArchitectureDbContext = cleanArchitectureDbContext;
        }

        public async Task<Status> GetStatusAsync()
        {
            return await _cleanArchitectureDbContext.Status.FirstOrDefaultAsync();
        }
    }
}