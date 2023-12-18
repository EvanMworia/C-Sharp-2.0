using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Models
{
    public class Professor
    {
        [Key]
        public int professorId {get; set;}
        public string professorName { get; set;}=string.Empty;
        public int departmentId { get; set; }
        public Department Departments { get; set; }

        List<Course> Courses = new List<Course>();

    }
}
