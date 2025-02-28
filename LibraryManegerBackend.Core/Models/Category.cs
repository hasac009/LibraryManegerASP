﻿using System.ComponentModel.DataAnnotations;

namespace LibraryManegerBackend.Core.Models;

public class Category
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}