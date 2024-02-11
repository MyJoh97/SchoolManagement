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
        }



        public CourseEntity GetCourseById(int id)
        {
            var CourseEntity = _courseRepository.Get(x => x.Id == id);
            return CourseEntity;
        }

        public IEnumerable<CourseEntity> GetCourses()
        {
            var courses = _courseRepository.GetAll();
            return courses;
        }

        public CourseEntity UpdateCourse(CourseEntity CourseEntity)
        {
            var CourseEntityUpdated = _courseRepository.Update(x => x.Id == CourseEntity.Id, CourseEntity);
            return CourseEntityUpdated;
        }

        public void DeleteCourse(int id)
        {
            _courseRepository.Delete(x => x.Id == id);
        }
    }
}
