using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        public string CourseName { get; set; }=string.Empty;
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
