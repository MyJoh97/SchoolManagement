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
        private readonly SchoolRepository _SchoolRepository;

        public SchoolService(SchoolRepository SchoolRepository)
        {
            _SchoolRepository = SchoolRepository;
        }



        public SchoolEntity CreateSchool(string schoolName)
        {
            var schoolEntity = _SchoolRepository.Get(x => x.SchoolName == schoolName);
            if (schoolEntity == null)
            {
                schoolEntity = _SchoolRepository.Create(new SchoolEntity { SchoolName = schoolName });
            }

            return schoolEntity;
        }

        public SchoolEntity GetSchoolByName(string schoolName)
        {
            var schoolEntity = _SchoolRepository.Get(x => x.SchoolName == schoolName);
            return schoolEntity;
        }

        public SchoolEntity GetSchoolById(int id)
        {
            var schoolEntity = _SchoolRepository.Get(x => x.Id == id);
            return schoolEntity;
        }

        public IEnumerable<SchoolEntity> GetSchools()
        {
            var schools = _SchoolRepository.GetAll();
            return schools;
        }

        public SchoolEntity UpdateSchool(SchoolEntity schoolEntity)
        {
            var schoolEntityUpdated = _SchoolRepository.Update(x => x.Id == schoolEntity.Id, schoolEntity);
            return schoolEntityUpdated;
        }

        public void DeleteSchool(int id)
        {
            _SchoolRepository.Delete(x => x.Id == id);
        }
    }
}
