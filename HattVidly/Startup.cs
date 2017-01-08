using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HattVidly.Startup))]
namespace HattVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
