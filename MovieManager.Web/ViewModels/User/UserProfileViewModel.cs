﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MovieManager.Core.Models;

namespace MovieManager.Web.ViewModels
{
    public class UserProfileViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
 
        [Required]
        [EmailAddress]
        [Remote(action: "GetUserByEmailAddress", controller: "User", AdditionalFields = nameof(Id))]
        public string Email { get; set; }

        [Required]
        public Role Role { get; set; }

    }
}