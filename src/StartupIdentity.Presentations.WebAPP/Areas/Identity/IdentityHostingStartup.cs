using Microsoft.AspNetCore.Hosting;

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