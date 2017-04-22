using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MiProyectoC.Startup))]
namespace MiProyectoC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
