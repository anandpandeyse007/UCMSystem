﻿using UCMS.Website.Models;

namespace UCMS.Website.Services
{
    public class CourseService : ICourseService
    {
        private readonly ApplicationDbContext _dbContext;
        public CourseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Course CreateCourse(Course enrollment)
        {
            throw new NotImplementedException();
        }

        public string DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public Course GetCourseById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public Course UpdateCourse(Course enrollment)
        {
            throw new NotImplementedException();
        }
    }
}
