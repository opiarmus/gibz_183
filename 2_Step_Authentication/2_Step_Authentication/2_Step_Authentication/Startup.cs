using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2_Step_Authentication.Startup))]
namespace _2_Step_Authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
