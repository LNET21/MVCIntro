using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntro.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Förnamn")]
        [StringLength(30, ErrorMessage = "Max 30 tecken")]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public int Salary { get; set; }

        [Range(18, 100)]
        public int Age { get; set; }
        public string  Department { get; set; }
    }
}
