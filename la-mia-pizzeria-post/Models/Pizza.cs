﻿using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_post.Models
{
    public class Pizza
    {
        public Pizza() { }
        public Pizza(string img, string name, string description, double price)
        {
            Img = img;
            Name = name;
            Description = description;
            Price = price;
        }

        [Key]
        public long Id { get; set; }
        [Url]
        public string Img { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [DescriptionValidation]
        [StringLength(100)]
        public string Description { get; set; }
        [Required]
        [Range(1, 20)]
        public double Price { get; set; }
    }
}