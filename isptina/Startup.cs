using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(isptina.Startup))]
namespace isptina
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
