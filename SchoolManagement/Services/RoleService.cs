using SchoolManagement.Entities;
using SchoolManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    internal class RoleService
    {
        private readonly RoleRepository _roleRepository;

        public RoleService(RoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }



        public RoleEntity CreateRole(string roleName)
        {
            var roleEntity = _roleRepository.Get(x => x.RoleName == roleName);
            if (roleEntity == null)
            {
                roleEntity = _roleRepository.Create(new RoleEntity { RoleName = roleName });
            }

            return roleEntity;
        }

        public RoleEntity GetRole(string roleName)
        {
            var roleEntity = _roleRepository.Get(x => x.RoleName == roleName);
            return roleEntity;
        }

        public RoleEntity GetRoleById(int id)
        {
            var roleEntity = _roleRepository.Get(x => x.Id == id);
            return roleEntity;
        }

        public IEnumerable<RoleEntity> GetRole()
        {
            var roleEntity = _roleRepository.GetAll();
            return roleEntity;
        }

        public RoleEntity UpdateRole(RoleEntity roleEntity)
        {
            var roleEntityUpdated = _roleRepository.Update(x => x.Id == roleEntity.Id, roleEntity);
            return roleEntityUpdated;
        }

        public void DeleteRole(int id)
        {
            _roleRepository.Delete(x => x.Id == id);
        }
    }
}
