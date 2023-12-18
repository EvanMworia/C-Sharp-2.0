using HospitalManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ADMINPC;Database=HospitalDB;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet <Appointment> Appointments { get; set; }
        public DbSet <Doctor> Doctors { get; set; }
        public DbSet <Patient> Patients { get; set; }
        public DbSet <Room> Rooms { get; set; }

    }
}
