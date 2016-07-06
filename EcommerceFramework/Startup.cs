using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EcommerceFramework.Startup))]
namespace EcommerceFramework
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
