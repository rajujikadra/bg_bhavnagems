using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BG.Startup))]
namespace BG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
