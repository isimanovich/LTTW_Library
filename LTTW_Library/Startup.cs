using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LTTW_Library.Startup))]
namespace LTTW_Library
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
