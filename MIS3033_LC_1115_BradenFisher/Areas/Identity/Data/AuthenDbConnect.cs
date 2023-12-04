using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MIS3033_LC_1115_BradenFisher.Areas.Identity.Data;

namespace MIS3033_LC_1115_BradenFisher.Data;

public class AuthenDbConnect : IdentityDbContext<AuthenUser>
{
    public AuthenDbConnect(DbContextOptions<AuthenDbConnect> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
