using System;
using Microsoft.Identity.Client;

using system;
using Microsoft.Identity.Tasks;
using Microsoft.Identity.Client;


namespace intoauthapp
{
    class Program
    {
        private const string _clientId = "5dd0efc8-882f-465d-be3c-dc158cec32f8";
        private const string _tenantId = "ca781c30-a391-4e6a-aca5-bcaf8e88f9d1";

        public static async Task Main(string[] args)
        {
            var app = PublicClientApplicationBuilder
                .Create(_clientId)
                .WithAuthority(AzureCloudInstance.AzurePublic, _tenantId)
                .WithRedirectUri("http://localhost")
                .Build(); 
            string[] scopes = { "user.read" };
            AuthenticationResult result = await app.AcquireTokenInteractive(scopes).ExecuteAsync();

            Console.WriteLine($"Token:\t{result.AccessToken}");
        }
    }
}