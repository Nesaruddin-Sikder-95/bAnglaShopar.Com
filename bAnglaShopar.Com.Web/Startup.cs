using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bAnglaShopar.Com.Web.Startup))]
namespace bAnglaShopar.Com.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
