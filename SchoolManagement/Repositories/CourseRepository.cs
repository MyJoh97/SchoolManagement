using SchoolManagement.Contexts;
using SchoolManagement.Entities;

namespace SchoolManagement.Repositories
{
    internal class CourseRepository : Repo<CourseEntity>
    {
        public CourseRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
