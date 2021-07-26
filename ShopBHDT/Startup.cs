using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShopBHDT.Startup))]
namespace ShopBHDT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
