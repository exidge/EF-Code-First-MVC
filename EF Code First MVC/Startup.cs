using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EF_Code_First_MVC.Startup))]
namespace EF_Code_First_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
