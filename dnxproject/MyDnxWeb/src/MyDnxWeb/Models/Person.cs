using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyDnxWeb.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }

        public string NickName { get; set; }
    }
}


