using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GitMetro.Services.GitHubServices;
using Octokit;

namespace GitMetro.Services.GitHubServices
{
    public static class GitHubIssue
    {
        /// <summary>
        /// Get issue by number in repository.
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        public static Task<Issue> Get(long repositoryId, int number)
        {
            return GitHubService.client.Issue.Get(repositoryId, number);
        }
        public static Task<Issue> Get(string owner, string name, int number)
        {
            return GitHubService.client.Issue.Get(owner, name, number);
        }

        /// <summary>
        /// Get list of open issues for current authenticated user.
        /// </summary>
        /// <returns></returns>
        public static Task<IReadOnlyList<Issue>> GetAllForCurrent()
        {
            return GitHubService.client.Issue.GetAllForCurrent();
        }
        public static Task<IReadOnlyList<Issue>> GetAllForCurrent(ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForCurrent(options);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForCurrent(IssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForCurrent(request);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForCurrent(IssueRequest request, ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForCurrent(request, options);
        }
        
        /// <summary>
        ///  Get all open issues for the provided organization.
        /// </summary>
        /// <param name="organization"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<Issue>> GetAllForOrganization(string organization)
        {
            return GitHubService.client.Issue.GetAllForOrganization(organization);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForOrganization(string organization, ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForOrganization(organization, options);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForOrganization(string organization, IssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForOrganization(organization, request);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForOrganization(string organization, ApiOptions options, IssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForOrganization(organization, request, options);
        }

        /// <summary>
        /// Gets all open issues assigned to the authenticated user across owned and member repositories for the authenticated user.
        /// </summary>
        /// <returns></returns>
        public static Task<IReadOnlyList<Issue>> GetAllForOwnedAndMemberRepositories()
        {
            return GitHubService.client.Issue.GetAllForOwnedAndMemberRepositories();
        }
        public static Task<IReadOnlyList<Issue>> GetAllForOwnedAndMemberRepositories(ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForOwnedAndMemberRepositories(options);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForOwnedAndMemberRepositories(IssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForOwnedAndMemberRepositories(request);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForOwnedAndMemberRepositories(IssueRequest request, ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForOwnedAndMemberRepositories(request, options);
        }

        /// <summary>
        /// Get all open issues assigned to authenticated user for repository
        /// </summary>
        /// <param name="repositoryId"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(long repositoryId)
        {
            return GitHubService.client.Issue.GetAllForRepository(repositoryId);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(long repositoryId, ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForRepository(repositoryId, options);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(long repositoryId, RepositoryIssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForRepository(repositoryId, request);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(string owner, string name)
        {
            return GitHubService.client.Issue.GetAllForRepository(owner, name);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(long repositoryId, RepositoryIssueRequest request, ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForRepository(repositoryId, request, options);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(string owner, string name, ApiOptions options)
        {
            return GitHubService.client.Issue.GetAllForRepository(owner, name, options);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(string owner, string name, RepositoryIssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForRepository(owner, name, request);
        }
        public static Task<IReadOnlyList<Issue>> GetAllForRepository(string owner, string name, ApiOptions options, RepositoryIssueRequest request)
        {
            return GitHubService.client.Issue.GetAllForRepository(owner, name, request, options);
        }

    }
}
