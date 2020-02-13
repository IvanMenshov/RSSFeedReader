using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RSSFeedReader.Startup))]
namespace RSSFeedReader
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
