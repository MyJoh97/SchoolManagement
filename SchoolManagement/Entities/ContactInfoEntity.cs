using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    internal class ContactInfoEntity
    {

        [Key]
        public int Id { get; set; }
        public string City { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string HomeAddress { get; set; } = null!;


    }
}
