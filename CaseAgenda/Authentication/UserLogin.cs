﻿using System.ComponentModel.DataAnnotations;

namespace CaseAgenda.Authentication
{
    public class UserLogin
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
