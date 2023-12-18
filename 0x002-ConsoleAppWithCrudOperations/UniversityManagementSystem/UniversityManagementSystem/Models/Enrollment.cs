using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityManagementSystem.Models
{
    public class Enrollment
    {
        public string Grade {  get; set; }=string.Empty;

        List<Student> Students { get; set; }
        List<Course> Courses { get; set; }


    }
}
