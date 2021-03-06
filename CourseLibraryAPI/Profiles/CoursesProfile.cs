﻿using System;
using AutoMapper;

namespace CourseLibraryAPI.Profiles
{
    public class CoursesProfile: Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, Models.CoursesDto>();
            CreateMap<Models.CourseForCreationDto, Entities.Course>();
            CreateMap<Models.CourseForUpdateDro, Entities.Course>();
            CreateMap<Entities.Course, Models.CourseForUpdateDro>();
        }
    }
}
