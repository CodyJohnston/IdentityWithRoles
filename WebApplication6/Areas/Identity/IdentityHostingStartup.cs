using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApplication6.Areas.Identity.Data;
using WebApplication6.Models;

[assembly: HostingStartup(typeof(WebApplication6.Areas.Identity.IdentityHostingStartup))]
namespace WebApplication6.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebApplication6Context>(options =>
                    options.UseSqlite(
                        context.Configuration.GetConnectionString("WebApplication6ContextConnection")));

                services.AddIdentity<WebApplication6User, IdentityRole>()
                    .AddRoleManager<RoleManager<IdentityRole>>()
                    .AddDefaultUI()
                    .AddDefaultTokenProviders()
                    .AddEntityFrameworkStores<WebApplication6Context>();
            });
        }
    }
}