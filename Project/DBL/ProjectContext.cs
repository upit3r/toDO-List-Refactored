using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DBL{
    public class ProjectContext : DbContext{
        public ProjectContext(DbContextOptions<ProjectContext> opt) : base(opt){

        }
        public DbSet <Command> Commands { get; set; }

    }
}