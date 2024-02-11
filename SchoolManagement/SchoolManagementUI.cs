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
        private readonly MemberService _memberService;

        public SchoolManagementUI(CourseService courseService, MemberService memberService)
        {
            _courseService = courseService;
            _memberService = memberService;
        }


        // Courses
        public void CreateCourse_UI()
        {
            Console.Clear();
            Console.WriteLine("### Create a Course ###");

            Console.Write("Course Name: ");
            var courseName = Console.ReadLine()!;

            Console.Write("School Name: ");
            var schoolName = Console.ReadLine()!;

            var result = _courseService.CreateCourse(courseName, schoolName);
            if (result != null)
            {
                Console.Clear();
                Console.WriteLine("The Course Was Created!");
                Console.ReadKey();
            }

        }

        public void GetCourses_UI()
        {

            Console.Clear();
            var courses = _courseService.GetCourses();
            foreach(var course in courses)
            {
                Console.WriteLine($"{course.CourseName} - {course.School.SchoolName}");
            }

            Console.ReadKey();
        }


        public void UpdateCourse_UI()
        {
            Console.Clear();
            Console.Write("Enter Course Id: ");
            var id = int.Parse(Console.ReadLine()!);

            var course = _courseService.GetCourseById(id);
            if (course != null)
            {
                Console.WriteLine($"{course.CourseName} - {course.School.SchoolName}");
                Console.WriteLine();

                Console.Write("New Course Name: ");
                course.CourseName = Console.ReadLine()!;

                var newCourse = _courseService.UpdateCourse(course);
                Console.WriteLine($"{course.CourseName} - {course.School.SchoolName}");
            } else
            {
                Console.WriteLine("No Course Was Found.");
            }

            Console.ReadKey();
        }


        public void DeleteCourse_UI()
        {
            Console.Clear();
            Console.Write("Enter Course Id: ");
            var id = int.Parse(Console.ReadLine()!);

            var course = _courseService.GetCourseById(id);
            if (course != null)
            {
                _courseService.DeleteCourse(course.Id);
                Console.WriteLine("The Course Was Deleted");
            }
            else
            {
                Console.WriteLine("No Course Was Found.");
            }

            Console.ReadKey();
        }



        // Members

        public void CreateMember_UI()
        {
            Console.Clear();
            Console.WriteLine("### Create a Member ###");

            Console.Write("First Name: ");
            var firstName = Console.ReadLine()!;

            Console.Write("Last Name: ");
            var lastName = Console.ReadLine()!;

            Console.Write("Email: ");
            var email = Console.ReadLine()!;

            Console.Write("City: ");
            var city = Console.ReadLine()!;

            Console.Write("Phonenumber: ");
            var number = Console.ReadLine()!;

            Console.Write("Home Addess: ");
            var address = Console.ReadLine()!;

            Console.Write("Role Name: ");
            var roleName = Console.ReadLine()!;

            var result = _memberService.CreateMember(firstName, lastName, email, roleName, city, number, address, roleName);
            if (result != null)
            {
                Console.Clear();
                Console.WriteLine("A Member W!");
                Console.ReadKey();
            }

        }

        public void GetMembers_UI()
        {

            Console.Clear();
            var members = _memberService.GetMembers();
            foreach (var member in members)
            {
                Console.WriteLine($"{member.FirstName} {member.LastName} <{member.Role.RoleName}>");
            }

            Console.ReadKey();
        }

    }
}
