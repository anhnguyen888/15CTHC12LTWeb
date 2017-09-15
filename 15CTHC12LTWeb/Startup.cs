using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_15CTHC12LTWeb.Startup))]
namespace _15CTHC12LTWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
