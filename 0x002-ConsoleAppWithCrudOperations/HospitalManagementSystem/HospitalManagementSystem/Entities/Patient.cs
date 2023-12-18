using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string FirstName { get; set;}=string.Empty;
        public  string LastName { get; set; } = string.Empty;
        public string Email { get; set;} = string.Empty;

        public int RoomId { get; set; }
        public Room rooms { get; set; }

        public int AppointmentId { get; set; }
        public List<Appointment> appointments { get; set; }


    }
}
