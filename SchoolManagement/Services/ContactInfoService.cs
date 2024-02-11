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
        private readonly ContactInfoRepository _contactInfoRepository;

        public ContactInfoService(ContactInfoRepository contactInfoRepository)
        {
            _contactInfoRepository = contactInfoRepository;
        }



        public ContactInfoEntity CreateContactInfo(string city, string phoneNumber, string homeAddress)
        {
            var contactInfoEntity = _contactInfoRepository.Get(x => x.City == city && x.PhoneNumber == phoneNumber && x.HomeAddress == homeAddress);
            if (contactInfoEntity == null)
            {
                contactInfoEntity = _contactInfoRepository.Create(new ContactInfoEntity { City = city, PhoneNumber = phoneNumber, HomeAddress = homeAddress });
            }

            return contactInfoEntity;
        }

        public ContactInfoEntity GetContactInfo(string city, string phoneNumber, string homeAddress)
        {
            var contactInfoEntity = _contactInfoRepository.Get(x => x.City == city && x.PhoneNumber == phoneNumber && x.HomeAddress == homeAddress);
            return contactInfoEntity;
        }

        public ContactInfoEntity GetContactInfoById(int id)
        {
            var contactInfoEntity = _contactInfoRepository.Get(x => x.Id == id);
            return contactInfoEntity;
        }

        public IEnumerable<ContactInfoEntity> GetContactInfo()
        {
            var contactInfo = _contactInfoRepository.GetAll();
            return contactInfo;
        }

        public ContactInfoEntity UpdateContactInfo(ContactInfoEntity contactInfoEntity)
        {
            var contactInfoEntityUpdated = _contactInfoRepository.Update(x => x.Id == contactInfoEntity.Id, contactInfoEntity);
            return contactInfoEntityUpdated;
        }

        public void DeleteContactInfo(int id)
        {
            _contactInfoRepository.Delete(x => x.Id == id);
        }
    }
}
