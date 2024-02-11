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
        private readonly SchoolService _schoolService;

        public CourseService(CourseRepository courseRepository, SchoolService schoolService)
        {
            _courseRepository = courseRepository;
            _schoolService = schoolService;
        }




        public CourseEntity CreateCourse(string courseName, string schoolName)
        {
            var schoolEntity = _schoolService.CreateSchool(schoolName);


            var courseEntity = new CourseEntity
            {
                CourseName = courseName,
                SchoolId = schoolEntity.Id,
            };

            courseEntity = _courseRepository.Create(courseEntity);
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
