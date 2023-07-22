using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UasKomber.Models;

namespace UasKomber.Services
{
    public class LoginService : ILoginRepository
    {
        public Task<Userinfo> Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
