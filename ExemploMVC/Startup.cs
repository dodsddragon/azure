using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExemploMVC.Startup))]
namespace ExemploMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
