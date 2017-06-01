using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleForm.Startup))]
namespace SimpleForm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
