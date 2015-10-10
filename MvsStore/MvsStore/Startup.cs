using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvsStore.Startup))]
namespace MvsStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
