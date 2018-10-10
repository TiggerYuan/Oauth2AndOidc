using IdentityServer4.Models;
using System.Collections;
using System.Collections.Generic;

namespace ApiServer
{
    public class Config
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client> {
                new Client{
                    ClientId="api",
                    AllowedGrantTypes=GrantTypes.Implicit,
                    ClientSecrets={
                        new Secret("secret", HashExtensions.Sha256("secret"))
                    },
                    AllowedCorsOrigins={ "api1"}
                }
            };
        }
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>()
            {
                new ApiResource()
            };
        }
    }
}
