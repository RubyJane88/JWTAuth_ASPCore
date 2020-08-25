using System;
using System.Collections.Generic;

namespace JWTAuth_ASPCore.Models
{
    public class AuthenticationModel
    {
        public string Message { get; set; }
        public bool isAuthenticated { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public List<string> Roles { get; set; } = new List<string>();
    }
}
