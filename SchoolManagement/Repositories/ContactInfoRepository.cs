using SchoolManagement.Contexts;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Repositories
{
    internal class ContactInfoRepository : Repo<ContactInfoEntity>
    {
        public ContactInfoRepository(DataContexts contexts) : base(contexts)
        {
        }
    }
}
