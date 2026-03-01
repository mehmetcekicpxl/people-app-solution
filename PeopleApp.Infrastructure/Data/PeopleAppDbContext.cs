using Microsoft.EntityFrameworkCore;
using PeopleApp.Domain.Models;

namespace PeopleApp.Infrastructure.Data
{
    public class PeopleAppDbContext : DbContext
    {
        public PeopleAppDbContext(DbContextOptions<PeopleAppDbContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
