﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using MovieManager.Core.Models;

namespace MovieManager.Web.ViewModels
{
    public class UserRegisterViewModel
    { 
        [Required]
        public string Name { get; set; }
 
        [Required]
        [EmailAddress]
        [Remote(action: "GetUserByEmailAddress", controller: "User")]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string PasswordConfirm  { get; set; }

        [Required]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Role Role { get; set; }

    }
}