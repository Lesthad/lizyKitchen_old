using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lizykitchen.Startup))]
namespace lizykitchen
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
