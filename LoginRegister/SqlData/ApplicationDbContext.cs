using LoginRegister.DTOs;
using LoginRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginRegister.SqlData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get;  set; }
    }
}
