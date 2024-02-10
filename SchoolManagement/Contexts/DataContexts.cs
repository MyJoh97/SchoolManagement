using Microsoft.EntityFrameworkCore;
using SchoolManagement.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Contexts
{
    internal class DataContexts : DbContext
    {
        public DataContexts(DbContextOptions<DataContexts> options) : base(options)
        {
        }

        public DbSet<ContactInfoEntity> ContactInfos { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<MemberEntity> Members { get; set; }
        public DbSet<RoleEntity> Roles { get; set; }
        public DbSet<SchoolEntity> Schools { get; set; }
    }
}
