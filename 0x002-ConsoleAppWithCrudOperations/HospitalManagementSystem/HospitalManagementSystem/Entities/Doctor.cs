using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        public string DoctorName { get; set; } = string.Empty;
        public string Specialty { get; set;} = string.Empty;

        public int AppointmentId { get; set; }
        public List<Appointment> appointments { get; set; }= new List<Appointment>();
    }
}
