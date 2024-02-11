using SchoolManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    internal class MemberService
    {
        private readonly MemberRepository _memberRepository;
        private readonly ContactInfoService _contactInfoService;
        private readonly RoleService _roleService;

        public MemberService(MemberRepository memberRepository, ContactInfoService contactInfoService, RoleService roleService)
        {
            _memberRepository = memberRepository;
            _contactInfoService = contactInfoService;
            _roleService = roleService;
        }
    }
}
