using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WapProject.Startup))]
namespace WapProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
