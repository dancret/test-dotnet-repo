using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sample.WebApp.Startup))]
namespace Sample.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
