﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManegerBackend.Core.Models;

public class User
{
    public int Id { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
    public string Role { get; set; } = "Client"; 
}