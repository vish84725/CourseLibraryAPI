using System;
using System.ComponentModel.DataAnnotations;
using CourseLibraryAPI.ValidationAttributes;

namespace CourseLibraryAPI.Models
{
    public class CourseForUpdateDro :  CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a description")]
        public override string Description
        {
            get => base.Description;
            set => base.Description = value;
        }
    }
}
