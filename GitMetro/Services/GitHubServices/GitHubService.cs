using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;
using Windows.Storage;

namespace GitMetro.Services.GitHubServices
{
    internal static class GitHubService
    {
        private const string clientId = "an-id-here";
        private const string clientSecret = "some-id-here";

        /// <summary>
        /// The client statically used for a user instance
        /// </summary>
        internal static GitHubClient client { get; } = new GitHubClient(new ProductHeaderValue("git-metro"));

        internal static async Task<bool> Authorize(string code)
        {
            string OAuthToken = null;
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("OAuthToken"))
            {
                object temp;
                ApplicationData.Current.LocalSettings.Values.TryGetValue("OAuthToken", out temp);
                OAuthToken = temp.ToString();
            }
            else
            {
                if (String.IsNullOrEmpty(code))
                    return false;

                var request = new OauthTokenRequest(clientId, clientSecret, code);
                var token = await client.Oauth.CreateAccessToken(request);
                ApplicationData.Current.LocalSettings.Values.Add("OAuthToken", token.AccessToken);
            }
            if (OAuthToken != null)
            {
                client.Credentials = new Credentials(OAuthToken);
                return true;
            }
            return false;
        }
    }
}
