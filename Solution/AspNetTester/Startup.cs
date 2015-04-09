using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetTester.Startup))]
namespace AspNetTester
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
