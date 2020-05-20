﻿using System;
using AutoMapper;

namespace CourseLibraryAPI.Profiles
{
    public class CoursesProfile: Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CoursesDto>();
        }
    }
}
