using System.ComponentModel.DataAnnotations;
using _72220556sampleWebApp.data;
using Microsoft.EntityFrameworkCore;

namespace SampleSecureWeb.Models;
public class User : ApplicationDbContext
{
    public User(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    [Key]
    public String Username { get; set;} = null!;
    public String Password { get; set;} = null!;
    public String RoleName { get; set;} = null!;
}