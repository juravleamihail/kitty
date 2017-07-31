using Microsoft.Owin;
using Owin;



[assembly: OwinStartupAttribute(typeof(KittyUI.Startup))]

namespace KittyUI

{

    public partial class Startup

    {
        public void Configuration(IAppBuilder app)

        {

            ConfigureAuth(app);

        }

    }

}