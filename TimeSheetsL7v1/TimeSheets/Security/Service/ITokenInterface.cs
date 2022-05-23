using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.JWT.Responce;

namespace TimeSheets.Security.Service
{
    public interface ITokenInterface
    {
        TokenResponse Authenticate(string user, string password);
        string RefreshToken(string token);
    }
}
