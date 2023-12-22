using System;

namespace GitHubActions.Application.Dtos
{
    public class StatusResponse
    {
        public DateTime Started { get; set; }
        public string Server { get; set; }
        public string OsVersion { get; set; }
    }
}
