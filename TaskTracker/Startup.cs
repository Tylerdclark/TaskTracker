using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TaskTracker.Startup))]
namespace TaskTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
