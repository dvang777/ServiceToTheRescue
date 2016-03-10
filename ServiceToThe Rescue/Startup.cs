using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServiceToTheRescue.Startup))]
namespace ServiceToTheRescue
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
