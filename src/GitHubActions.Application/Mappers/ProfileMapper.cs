using AutoMapper;
using GitHubActions.Application.Dtos;
using GitHubActions.Domain.Entities;

namespace GitHubActions.Application.Mappers
{
    public class ProfileMapper : Profile
    {
        public ProfileMapper()
        {
            CreateMap<Status, StatusResponse>();
        }
    }
}
