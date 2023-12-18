using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityManagementSystem.Models;
//using entity framework video @21:17 

namespace UniversityManagementSystem.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Department>Departments { get; set; }
        public DbSet<Professor>Professors { get; set; }

        public DbSet<Student>Students { get; set; }
    }
}
