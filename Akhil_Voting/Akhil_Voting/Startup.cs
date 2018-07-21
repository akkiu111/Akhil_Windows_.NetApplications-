using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Akhil_Voting.Startup))]
namespace Akhil_Voting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
