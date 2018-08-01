using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestingInterview.WebClient.Startup))]
namespace TestingInterview.WebClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
