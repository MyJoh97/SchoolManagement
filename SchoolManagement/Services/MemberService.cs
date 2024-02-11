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




        public MemberEntity CreateMember(string firstName, string lastName, string email, string roleName, string city, string phoneNumber, string homeAddress, string roleName1)
        {
            var roleEntity = _roleService.CreateRole(roleName);
            var contactInfoEntity = _contactInfoService.CreateContactInfo(city, phoneNumber, homeAddress);

            var memberEntity = new MemberEntity
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                RoleId = roleEntity.Id,
                ContactInfoId = contactInfoEntity.Id
            };

            memberEntity = _memberRepository.Create(memberEntity);
            return memberEntity;
        }




        public MemberEntity GetMemberByEmail(string email)
        {
            var memberEntity = _memberRepository.Get(x => x.Email == email);
            return memberEntity;
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
