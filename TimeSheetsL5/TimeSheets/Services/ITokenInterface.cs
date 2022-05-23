using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeSheets.JWT.Responce;

namespace TimeSheets.Services
{
    public interface ITokenInterface
    {
        TokenResponse Authenticate(string user, string password);
        string RefreshToken(string token);
    }
}
