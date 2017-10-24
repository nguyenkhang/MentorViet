using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MentorViet.WebApplication.Startup))]
namespace MentorViet.WebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
