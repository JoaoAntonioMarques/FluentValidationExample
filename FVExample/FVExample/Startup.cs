using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FVExample.Startup))]
namespace FVExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
