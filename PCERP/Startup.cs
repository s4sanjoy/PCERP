using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PCERP.Startup))]
namespace PCERP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
