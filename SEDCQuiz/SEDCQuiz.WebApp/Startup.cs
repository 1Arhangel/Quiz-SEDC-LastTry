using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEDCQuiz.WebApp.Startup))]
namespace SEDCQuiz.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
