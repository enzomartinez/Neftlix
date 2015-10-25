using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Neftlix.Startup))]
namespace Neftlix
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
