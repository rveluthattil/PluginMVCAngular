using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluginMVCAngular.Startup))]
namespace PluginMVCAngular
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
