using System;
using System.ComponentModel.DataAnnotations;

namespace LMS.web.Areas.Demos.ViewModels
{
    public class EmployeeViewModel
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Name Of the Employee")]
        [Required(ErrorMessage ="{0} Cannot be empty")]
        [MaxLength(80, ErrorMessage ="{0} can contain maximum of {1} character")]
        [MinLength(2,ErrorMessage ="{0} should contain a minimum of {1} character")]
        public string EmpolyeeName {get; set;}

        [Display(Name ="Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set;}

        [Range(minimum:0, maximum:2000000,ErrorMessage ="{0} has to be between {1} and {2}")]
        public decimal Salary { get; set;}

        [Display(Name ="Is Employee allowed to login")]
        public bool IsEnabled { get; set;}
    }
}
