using CommandLineSnippets.Models;
using Microsoft.EntityFrameworkCore;

namespace CommandLineSnippets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Command> CommandSnippets {get; set;}
    }
}