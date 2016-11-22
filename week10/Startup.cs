using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(week10.Startup))]
namespace week10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
