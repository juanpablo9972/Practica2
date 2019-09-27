﻿using System.ComponentModel.DataAnnotations;

namespace mvcPhone.Models
{
    public enum TypeContact
    {
        Facebook,
        Twitter,
        LinkedIN,
        Instagram,

    }

    public class Phone
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public TypeContact Type { get; set; }

        [Required]
        public string Contact { get; set; }

    }
}