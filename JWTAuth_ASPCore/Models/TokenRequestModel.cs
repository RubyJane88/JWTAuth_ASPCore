using System;
using System.ComponentModel.DataAnnotations;

namespace JWTAuth_ASPCore.Models
{
    public class TokenRequestModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
