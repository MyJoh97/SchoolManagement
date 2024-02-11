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
            var SchoolEntity = _SchoolRepository.Get(x => x.SchoolName == schoolName);
            if (SchoolEntity == null)
            {
                SchoolEntity = _SchoolRepository.Create(new SchoolEntity { SchoolName = schoolName });
            }

            return SchoolEntity;
        }

        public SchoolEntity GetSchoolByName(string schoolName)
        {
            var SchoolEntity = _SchoolRepository.Get(x => x.SchoolName == schoolName);
            return SchoolEntity;
        }

        public SchoolEntity GetSchoolById(int id)
        {
            var SchoolEntity = _SchoolRepository.Get(x => x.Id == id);
            return SchoolEntity;
        }

        public IEnumerable<SchoolEntity> GetSchools()
        {
            var schools = _SchoolRepository.GetAll();
            return schools;
        }

        public SchoolEntity UpdateSchool(SchoolEntity SchoolEntity)
        {
            var SchoolEntityUpdated = _SchoolRepository.Update(x => x.Id == SchoolEntity.Id, SchoolEntity);
            return SchoolEntityUpdated;
        }

        public void DeleteSchool(int id)
        {
            _SchoolRepository.Delete(x => x.Id == id);
        }
    }
}
