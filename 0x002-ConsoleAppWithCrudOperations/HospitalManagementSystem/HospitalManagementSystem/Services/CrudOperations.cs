using HospitalManagementSystem.Data;
using HospitalManagementSystem.Entities;
using HospitalManagementSystem.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services
{
    public class CrudOperations : ICrudMethods
    {
        public bool CreateAppointment(Appointment appointment, DataContext context)
        {
            try
            {
                context.Appointments.Add(appointment);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine($"\t it looks like: {e.InnerException.Message}");
                return false;
            }
        }

        public List<Appointment> GetAppointments(DataContext context)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetPatients(DataContext context)
        {
            throw new NotImplementedException();
        }
    }
}
