using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Test;

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
                },
                new Client
                {
                    ClientId="pwdClient",
                    AllowedGrantTypes={ GrantType.ResourceOwnerPassword},
                    ClientSecrets ={new Secret("secret".Sha256())},
                    AllowedScopes={ "api" }
                }
            };
        }

        public static List<TestUser> GetTestUsers()
        {
            return new List<TestUser> {
            new TestUser{
                SubjectId="1",
                Username="lxg",
                Password="123456"
            } };
        }

    }
}
