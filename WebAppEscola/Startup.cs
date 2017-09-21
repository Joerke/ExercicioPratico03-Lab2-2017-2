using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppEscola.Startup))]
namespace WebAppEscola
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
