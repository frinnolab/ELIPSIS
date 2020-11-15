using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ElipsisInterview.Startup))]
namespace ElipsisInterview
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
