using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(myTestProject.Startup))]
namespace myTestProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
