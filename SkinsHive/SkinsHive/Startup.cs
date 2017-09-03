using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkinsHive.Startup))]
namespace SkinsHive
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
