using HospitalManagementSystem.Data;
using HospitalManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Services.IServices
{
    public interface ICrudMethods
    {
        //Remember to add more ICrudMethhods since they define any CRUD operations we would like to perfom
        //TO DO 
        bool CreateAppointment(Appointment appointment, DataContext context);
        List<Appointment> GetAppointments(DataContext context);
        List<Patient> GetPatients(DataContext context);
    }
}
