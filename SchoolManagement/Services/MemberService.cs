using SchoolManagement.Entities;
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



        public MemberEntity GetMemberById(int id)
        {
            var memberEntity = _memberRepository.Get(x => x.Id == id);
            return memberEntity;
        }

        public IEnumerable<MemberEntity> GetMembers()
        {
            var members = _memberRepository.GetAll();
            return members;
        }

        public MemberEntity UpdateMember(MemberEntity memberEntity)
        {
            var MemberEntityUpdated = _memberRepository.Update(x => x.Id == memberEntity.Id, memberEntity);
            return MemberEntityUpdated;
        }

        public void DeleteMember(int id)
        {
            _memberRepository.Delete(x => x.Id == id);
        }
    }
}
