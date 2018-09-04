using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppAro.Startup))]
namespace WebAppAro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
