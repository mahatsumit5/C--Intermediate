using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.data
{
    public class DataContextEF:DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        private readonly string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, optionsBuilder => optionsBuilder.EnableRetryOnFailure());
            } 
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // look into TutorialAppSchama for Computer
            modelBuilder.HasDefaultSchema("TutorialAppSchema");
            modelBuilder.Entity<Computer>().HasKey(c => c.ComputerId);
            // HasNoKey();
            // .ToTable("Computer", "TutorialAppSchema");
            // .ToTable("TableName", "SchemaNAme");
           
        }


    }

}