﻿using Microsoft.AspNetCore.Identity;

namespace AuthentificationAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
