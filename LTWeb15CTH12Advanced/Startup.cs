using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LTWeb15CTH12Advanced.Startup))]
namespace LTWeb15CTH12Advanced
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
