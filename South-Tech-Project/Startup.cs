using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(South_Tech_Project.Startup))]
namespace South_Tech_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
