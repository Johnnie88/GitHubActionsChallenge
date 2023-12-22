using AutoMapper;
using GitHubActions.Application.Dtos;
using System.Threading.Tasks;
using GitHubActions.Domain.Interfaces;
using IStatusService = GitHubActions.Application.Interfaces.IStatusService;

namespace GitHubActions.Application.Entities
{
    public class StatusService : IStatusService
    {
        private readonly IStatusRepository _statusRepository;
        private readonly IMapper _mapper;

        public StatusService(IStatusRepository statusRepository, IMapper mapper)
        {
            _statusRepository = statusRepository;
            _mapper = mapper;
        }

        public async Task<StatusResponse> GetStatusAsync()
        {
           var status = await _statusRepository.GetStatusAsync();

           return _mapper.Map<StatusResponse>(status);
        }
    }
}
