using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week13.Startup))]
namespace Week13
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
