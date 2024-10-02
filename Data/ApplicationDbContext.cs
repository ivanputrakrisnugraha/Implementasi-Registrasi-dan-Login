using System;
using _72220556sampleWebApp.Models;
using Microsoft.EntityFrameworkCore;
using SampleSecureWeb.Models;

namespace _72220556sampleWebApp.data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
{
}
public DbSet<Student> Students { get; set; } = null!;
}