using System.Reflection;
using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class EstimationToolContext : DbContext
    {
        public EstimationToolContext(DbContextOptions<EstimationToolContext> options) : base(options)
        {
        }

        public DbSet<PartType> PartType {get; set;}
        public DbSet<TaskType> TaskType {get; set;}
        public DbSet<Part> Part {get; set;}
        public DbSet<Task> Task {get; set;}
        public DbSet<Estimate> Estimate {get; set;}
        public DbSet<Proyect> Proyect {get; set;}
        public DbSet<Preferences> Preferences {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}