using SchoolManagement.Entities;
using SchoolManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    internal class SchoolService
    {
        private readonly SchoolRepository _schoolRepository;
        private readonly CourseService _courseService;

        public SchoolService(SchoolRepository schoolRepository, CourseService courseService)
        {
            _schoolRepository = schoolRepository;
            _courseService = courseService;
        }




        public SchoolEntity CreateRole(string roleName)
        {
            var SchoolEntity = _schoolRepository.Get(x => x.RoleName == roleName);
            if (SchoolEntity == null)
            {
                SchoolEntity = _schoolRepository.Create(new SchoolEntity { RoleName = roleName });
            }

            return SchoolEntity;
        }

        public SchoolEntity GetRole(string roleName)
        {
            var SchoolEntity = _schoolRepository.Get(x => x.RoleName == roleName);
            return SchoolEntity;
        }

        public SchoolEntity GetRoleById(int id)
        {
            var SchoolEntity = _schoolRepository.Get(x => x.Id == id);
            return SchoolEntity;
        }

        public IEnumerable<SchoolEntity> GetSchools()
        {
            var schools = _schoolRepository.GetAll();
            return schools;
        }

        public SchoolEntity UpdateSchool(SchoolEntity SchoolEntity)
        {
            var SchoolEntityUpdated = _schoolRepository.Update(x => x.Id == SchoolEntity.Id, SchoolEntity);
            return SchoolEntityUpdated;
        }

        public void DeleteRole(int id)
        {
            _schoolRepository.Delete(x => x.Id == id);
        }
    }
}
