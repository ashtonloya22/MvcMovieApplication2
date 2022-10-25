using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcMovieApplication2.Data;

[assembly: HostingStartup(typeof(MvcMovieApplication2.Areas.Identity.IdentityHostingStartup))]
namespace MvcMovieApplication2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MvcMovieApplication2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MvcMovieApplication2ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<MvcMovieApplication2Context>();
            });
        }
    }
}
