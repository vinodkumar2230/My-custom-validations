using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Customvalidations.Models
{
    public class Employee
    {
        //this is my project
        [Required]
        public string Name { get; set; }
        [Required]
        [CustomEmailValidator]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        public string City { get; set; }

    }
}