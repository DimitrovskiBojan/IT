using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_Aplikacija.Startup))]
namespace IT_Aplikacija
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
