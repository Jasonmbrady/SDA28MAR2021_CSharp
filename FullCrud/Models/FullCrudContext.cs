using Microsoft.EntityFrameworkCore;

namespace FullCrud.Models
{
    public class FullCrudContext : DbContext
    {
        public FullCrudContext(DbContextOptions options) : base(options) {}

        public DbSet<User> Users {get;set;}
    }
}