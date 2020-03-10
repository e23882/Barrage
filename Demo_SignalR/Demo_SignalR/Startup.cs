using Owin;
using Microsoft.Owin;

//請注意namespace，複製貼上後請更改為你取的
[assembly: OwinStartup(typeof(Demo_SignalR.Startup))]
namespace Demo_SignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}