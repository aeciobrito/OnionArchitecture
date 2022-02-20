using Microsoft.EntityFrameworkCore;
using Domain.EntityMapper;

namespace Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
