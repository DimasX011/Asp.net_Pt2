using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Security.Models
{
    public class AuthResponse
    {
        public string Password { get; set; }

        public RefreshToken LatestRefreshToken { get; set; }
    }
}
