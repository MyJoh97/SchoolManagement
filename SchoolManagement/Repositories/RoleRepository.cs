using SchoolManagement.Contexts;
using SchoolManagement.Entities;

namespace SchoolManagement.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
