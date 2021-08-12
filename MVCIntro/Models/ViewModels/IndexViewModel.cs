using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntro.Models.ViewModels
{
    public class IndexViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Förnamn")]
        [StringLength(30, ErrorMessage = "Max 30 tecken")]
        public string Name { get; set; }

        [Range(0, 1000000)]
        public int Salary { get; set; }

      
    }
}
