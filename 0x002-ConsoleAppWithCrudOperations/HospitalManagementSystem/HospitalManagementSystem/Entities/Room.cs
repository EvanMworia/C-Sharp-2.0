using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        public string RoomNumber { get; set; }=string.Empty;

        public string RoomType { get; set;} = string.Empty;

        public List<Patient> patients { get; set; } = new List<Patient>();

    }
}
