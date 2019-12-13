using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Konyvaru.Startup))]
namespace Konyvaru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
