using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OlyfauntService.Startup))]

namespace OlyfauntService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}