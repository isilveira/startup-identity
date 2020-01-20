using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StartupIdentity.Presentations.WebAPP.Data;

[assembly: HostingStartup(typeof(StartupIdentity.Presentations.WebAPP.Areas.Identity.IdentityHostingStartup))]
namespace StartupIdentity.Presentations.WebAPP.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}