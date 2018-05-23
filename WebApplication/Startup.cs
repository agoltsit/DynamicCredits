using Microsoft.Owin;
using WebApplication;

[assembly: OwinStartup(typeof(Startup))]

namespace WebApplication
{
    using Owin;

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}