using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace IdentityServerCenter
{
    public static class Config
    {
        //api地址
        public static IEnumerable<ApiResource> GetResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api","My Api")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId="client",
                    AllowedGrantTypes={ GrantType.ClientCredentials},
                    ClientSecrets ={new Secret("secret".Sha256())},
                    AllowedScopes={ "api" }//ApiResource
                }
            };
        }
    }
}
