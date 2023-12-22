using System.Threading.Tasks;
using GitHubActions.Domain.Entities;

namespace GitHubActions.Domain.Interfaces
{
    public interface IStatusRepository
    {
        /// <summary>
        /// Gets the service status
        /// </summary>
        /// <returns>The Service <see cref="Status"/></returns>
        Task<Status> GetStatusAsync();
    }
}
