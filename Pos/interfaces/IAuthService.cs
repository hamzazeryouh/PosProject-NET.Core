using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core.Entities;

namespace Pos.interfaces
{ interface IAuthServices
{
        Task<Users> Login(string username, string password);
        Task<Users> Register(Users user, string password);
        Task<bool> UserExists(string username);
        Task Register(AspNetUsers userToCreate, string password);
    }
}
