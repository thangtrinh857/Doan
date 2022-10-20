[assembly: HostingStartup(typeof(Accessories.Areas.Identity.IdentityHostingStartup))]
namespace Accessories.Areas.Identity
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
