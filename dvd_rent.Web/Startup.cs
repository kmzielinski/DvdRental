﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(dvd_rent.Web.Startup))]

namespace dvd_rent.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}