﻿using _0_Framework.Application;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Application.Contracts.Account
{
    public class RegisterAccount
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Name { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Family { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Email { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Username { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Password { get; set; }

        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        public long RoleId { get; set; }

        public IFormFile ProfilePhoto { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
