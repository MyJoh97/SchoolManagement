using SchoolManagement.Contexts;
using SchoolManagement.Entities;

namespace SchoolManagement.Repositories
{
    internal class MemberRepository : Repo<MemberEntity>
    {
        public MemberRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
