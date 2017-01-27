using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SuperAdminFCS.Startup))]
namespace SuperAdminFCS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
