﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;


namespace MVCCore.Models
{
    public class Login  
    {

        [Required]
        [Display(Name = "User Name")]
        [MaxLength(50)]
        public string UserName { get; set; }
        
        [Required]
        [Display(Name = "Password")]
        [MaxLength(50)]
        public string Password { get; set; }
    }

    
}