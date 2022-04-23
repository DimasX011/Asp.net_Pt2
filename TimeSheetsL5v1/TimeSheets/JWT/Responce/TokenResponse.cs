using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeSheets.JWT.Responce
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
