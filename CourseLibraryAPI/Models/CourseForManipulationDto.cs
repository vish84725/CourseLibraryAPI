using System;
using System.ComponentModel.DataAnnotations;
using CourseLibraryAPI.ValidationAttributes;

namespace CourseLibraryAPI.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "Title must be different from description.")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "You should fill out a title.")]
        [MaxLength(100, ErrorMessage = "The title should'nt have more thatn 100 characters.")]
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "The description should'nt have more than 1500 characters.")]
        public virtual string Description { get; set; }
    }
}
