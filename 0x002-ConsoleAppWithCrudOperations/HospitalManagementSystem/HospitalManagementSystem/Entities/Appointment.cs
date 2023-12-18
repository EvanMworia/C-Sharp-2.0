using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; } = DateTime.Now;


        public int PatientId { get; set; }
        public List<Patient> patients { get; set; } = new List<Patient>();

        public int DoctorId { get; set; }
        public List<Doctor> doctors { get; set; } = new List<Doctor>();

    }
}
