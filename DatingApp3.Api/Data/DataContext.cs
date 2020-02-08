using DatingApp3.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp3.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Value> Values { get; set; }
    }
}