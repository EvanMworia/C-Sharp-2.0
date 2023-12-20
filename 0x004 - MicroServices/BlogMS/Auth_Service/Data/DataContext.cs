using Auth_Service.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Auth_Service.Data
{
    public class DataContext:IdentityDbContext<BlogUser>
    {
        public DataContext(DbContextOptions<DataContext> option):base(option) { }

        public DbSet<BlogUser> Users {  get; set; }
    }
}
