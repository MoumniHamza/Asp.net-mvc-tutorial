using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesModel.Startup))]
namespace MoviesModel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
