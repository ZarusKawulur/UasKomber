using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UasKomber.Models;

namespace UasKomber.Services
{
    public interface ILoginRepository
    {
        Task<Userinfo> Login(string username, string password);
    }
}
