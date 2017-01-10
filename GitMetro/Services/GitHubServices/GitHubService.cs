using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace GitMetro.Services.GitHubServices
{
    internal static class GitHubService
    {
        /// <summary>
        /// The client statically used for a user instance
        /// </summary>
        internal static GitHubClient client { get; } = new GitHubClient(new ProductHeaderValue("git-metro"));
    }
}
