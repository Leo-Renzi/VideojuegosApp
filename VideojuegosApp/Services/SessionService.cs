using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideojuegosApp.Services
{
    public class SessionService
    {
        public bool IsLoggedIn { get; private set; } = false;
        public string? CurrentUser { get; private set; }

        public void Login(string username)
        {
            IsLoggedIn = true;
            CurrentUser = username;
        }

        public void Logout()
        {
            IsLoggedIn = false;
            CurrentUser = null;
        }
    }
}
