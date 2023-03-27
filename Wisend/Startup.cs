using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wisend.Startup))]
namespace Wisend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
