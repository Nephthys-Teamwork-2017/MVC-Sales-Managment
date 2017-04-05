using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SalesInsuranceManagment.Startup))]
namespace SalesInsuranceManagment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
