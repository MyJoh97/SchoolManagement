using SchoolManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    internal class SchoolManagementUI
    {

        private readonly CourseService _courseService;

        public SchoolManagementUI(CourseService courseService)
        {
            _courseService = courseService;
        }


        public void CreateCourse_UI()
        {
            Console.Clear();
            Console.WriteLine("### Create a Course ###");

            Console.Write("Course Name: ");
            var courseTitle = Console.ReadLine()!;

            Console.Write("School Name: ");
            var schoolName = Console.ReadLine()!;

            var result = _courseService.CreateCourse(courseTitle, schoolName);
            if (result != null)
            {
                Console.Clear();
                Console.WriteLine("The Course Was Created!");
            }


        }

    }
}
