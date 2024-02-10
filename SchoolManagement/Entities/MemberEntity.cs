using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    internal class MemberEntity
    {

        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;

        public int RoleId { get; set; }
        public RoleEntity Role { get; set; } = null!;

        public int ContactInfoId { get; set; }
        public ContactInfoEntity ContactInfo { get; set; } = null!;



    }
}
