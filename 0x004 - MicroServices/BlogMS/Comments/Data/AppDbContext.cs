using Comments.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Comments.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Comment> Comments { get; set; }
    }
}