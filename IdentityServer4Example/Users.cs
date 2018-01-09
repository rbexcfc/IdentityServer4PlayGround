using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityModel;
using IdentityServer4.Test;

namespace IdentityServer4Example
{
    internal class Users
    {
        public static List<TestUser> Get()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "Rich",
                    Password = "password",
                    Claims = new List<Claim>
                    {
                        new Claim(JwtClaimTypes.Email,"notsolite@hotmail.co.uk"),
                        new Claim(JwtClaimTypes.Role,"admin")
                    }
                }
            };
        }
    }
}
