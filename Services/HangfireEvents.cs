using System;

namespace netcoreapi_eventful_app.Services
{
    public interface IHangfireEvents
    {
        void RunDemoTask();
    }

    public class HangfireEvents : IHangfireEvents
    {
        public void RunDemoTask()
        {
            Console.WriteLine("This is a task running from HangfireEvents");
        }
    }
}