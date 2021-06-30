using Microsoft.EntityFrameworkCore;

namespace LoginReg.Models
{
    public class LogRegContext : DbContext
    {
        public LogRegContext(DbContextOptions options) : base(options){}
        public DbSet<User> Users {get;set;}
    }
}