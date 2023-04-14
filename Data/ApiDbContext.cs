using Microsoft.EntityFrameworkCore;
using WebApiP.Models;

namespace WebApiP.Data;

public class ApiDbContext : DbContext
{

    // DbSet<Model>
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Projects { get; set; }

    public ApiDbContext(DbContextOptions<ApiDbContext> opt): base(opt)
    {

    }
    
}