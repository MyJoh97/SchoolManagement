using Microsoft.EntityFrameworkCore;
using SchoolManagement.Contexts;
using SchoolManagement.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace SchoolManagement.Repositories
{
    internal class MemberRepository : Repo<MemberEntity>
    {


        private readonly DataContexts _contexts;

        public MemberRepository(DataContexts contexts) : base(contexts)
        {
            _contexts = contexts;
        }

        public override MemberEntity Get(Expression<Func<MemberEntity, bool>> expression)
        {
            var entity = _contexts.Members
                .Include(i => i.ContactInfo)
                .Include(i => i.Role)
                .FirstOrDefault(expression);

            return entity!;
        }

        public override IEnumerable<MemberEntity> GetAll()
        {
            return _contexts.Members
                .Include(i => i.ContactInfo)
                .Include(i => i.Role)
                .ToList();
        }
    }
}
