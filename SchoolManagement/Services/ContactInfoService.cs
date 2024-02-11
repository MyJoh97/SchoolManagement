using SchoolManagement.Entities;
using SchoolManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Services
{
    internal class ContactInfoService
    {
        private readonly ContactInfoService _contactInfoService;

        public ContactInfoService(ContactInfoService contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }



        public ContactInfoEntity CreateCourse(string city, string phoneNumber, string homeAddress)
        {
            var contactInfoEntity = _ContactInfoRepository.Get(x => x.City == city && x.PhoneNumber == phoneNumber && x.HomeAddress == homeAddress);
            if (contactInfoEntity == null)
            {
                contactInfoEntity = _ContactInfoRepository.Create(new ContactInfoEntity { CourseName = courseName });
            }

            return contactInfoEntity;
        }

        public ContactInfoEntity GetCourseByName(string courseName)
        {
            var contactInfoEntity = _ContactInfoRepository.Get(x => x.CourseName == courseName);
            return contactInfoEntity;
        }

        public ContactInfoEntity GetCourseById(int id)
        {
            var contactInfoEntity = _ContactInfoRepository.Get(x => x.Id == id);
            return contactInfoEntity;
        }

        public IEnumerable<ContactInfoEntity> GetCourses()
        {
            var courses = _courseRepository.GetAll();
            return courses;
        }

        public ContactInfoEntity UpdateCourse(ContactInfoEntity contactInfoEntity)
        {
            var contactInfoEntityUpdated = _ContactInfoRepository.Update(x => x.Id == courseEntity.Id, contactInfoEntity);
            return contactInfoEntityUpdated;
        }

        public void DeleteCourse(int id)
        {
            _ContactInfoRepository.Delete(x => x.Id == id);
        }
    }
}
