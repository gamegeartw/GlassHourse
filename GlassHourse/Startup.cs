using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GlassHourse.Startup))]
namespace GlassHourse
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
