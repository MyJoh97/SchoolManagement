using Microsoft.EntityFrameworkCore;
using SchoolManagement.Contexts;
using SchoolManagement.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace SchoolManagement.Repositories
{
    internal class CourseRepository : Repo<CourseEntity>
    {
        private readonly DataContexts _contexts;

        public CourseRepository(DataContexts contexts) : base(contexts)
        {
        }

        public override CourseEntity Get(Expression<Func<CourseEntity, bool>> expression)
        {
            var entity = _contexts.Courses
                .Include(i => i.School)
                .FirstOrDefault(expression);

            return entity!;
        }

        public override IEnumerable<CourseEntity> GetAll()
        {
            return _contexts.Courses
                .Include(i => i.School)
                .ToList();
        }
    }
}
