﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username must be between 5 and 15 characters.")]
        [StringLength(15, MinimumLength = 5)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password must be between 6 and 20 characters")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [Required]
        public string VerifyPassword { get; set; }
    }
}
