using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    internal class CourseEntity
    {

        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; } = null!;
        public int SchoolId { get; set; }
        public SchoolEntity School { get; set; }


    }
}
