using SchoolManagement.Entities;
using SchoolManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    internal class CourseService
    {
        private readonly CourseRepository _courseRepository;

        public CourseService(CourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }



        public CourseEntity CreateCourse(string courseName)
        {
            var courseEntity = _courseRepository.Get(x => x.CourseName == courseName);
            if (courseEntity == null)
            {
                courseEntity = _courseRepository.Create(new CourseEntity { CourseName = courseName });
            }

            return courseEntity;
        }

        public CourseEntity GetCourseByName(string courseName)
        {
            var courseEntity = _courseRepository.Get(x => x.CourseName == courseName);
            return courseEntity;
        }

        public CourseEntity GetCourseById(int id)
        {
            var courseEntity = _courseRepository.Get(x => x.Id == id);
            return courseEntity;
        }

        public IEnumerable<CourseEntity> GetCourses()
        {
            var courses = _courseRepository.GetAll();
            return courses;
        }

        public CourseEntity UpdateCourse(CourseEntity courseEntity)
        {
            var courseEntityUpdated = _courseRepository.Update(x => x.Id == courseEntity.Id, courseEntity);
            return courseEntityUpdated;
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.Delete(x => x.Id == id);
        }
    }
}
