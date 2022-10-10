using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class UserExtension
    {
        public static long GetUserId(this IIdentity claims)
        {
            return Convert.ToInt64((claims as ClaimsIdentity).Claims.FirstOrDefault(x => x.Type == ClaimTypes.Sid.ToString())?.Value);
        }
    }
}
