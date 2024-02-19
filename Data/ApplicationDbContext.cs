using AssessmentUserInterface.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "UserDb");
    }

    public DbSet<User> Users { get; set; }

}
