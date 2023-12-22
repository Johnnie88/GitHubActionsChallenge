using System;
using System.ComponentModel.DataAnnotations;

namespace GitHubActions.Domain.Entities
{
    public class Status
    {
        [Key]
        public DateTime Started { get; set; }
        public string Server { get; set; }
        public string OsVersion { get; set; }
    }
}
