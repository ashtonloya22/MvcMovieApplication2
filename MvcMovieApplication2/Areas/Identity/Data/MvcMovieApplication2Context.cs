using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MvcMovieApplication2.Data;

public class MvcMovieApplication2Context : IdentityDbContext<IdentityUser>
{
    public MvcMovieApplication2Context(DbContextOptions<MvcMovieApplication2Context> options)
        : base(options)
    {
    }

    public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
