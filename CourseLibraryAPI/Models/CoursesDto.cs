﻿using System;
namespace CourseLibraryAPI.Models
{
    public class CoursesDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Guid AuthorId { get; set; }
    }
}
