using Comments.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Comments.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
        
    }
}