using SchoolManagement.Contexts;
using SchoolManagement.Entities;

namespace SchoolManagement.Repositories
{
    internal class SchoolRepository : Repo<SchoolEntity>
    {
        public SchoolRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
