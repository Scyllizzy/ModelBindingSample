using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBindingSample.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "DOB")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Favorite Number")]
        [Required] // in is always required because it's a value type
        [Range(1, 100, ErrorMessage = "Choose between 1 and 100")]
        public int FavoriteNumber { get; set; } //Int is required at all times

    }
}
