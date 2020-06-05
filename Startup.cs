using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KitapKurdu.Startup))]
namespace KitapKurdu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
