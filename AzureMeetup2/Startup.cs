using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AzureMeetup2.Startup))]
namespace AzureMeetup2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
