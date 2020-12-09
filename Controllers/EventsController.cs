using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using netcoreapi_eventful_app.Services;

namespace netcoreapi_eventful_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventsController : ControllerBase
    {
        private IHangfireEvents hangfireEvents;
        public EventsController(IHangfireEvents hangfireEvents)
        {
            this.hangfireEvents = hangfireEvents;
        }

        [HttpGet]
        public IActionResult Get()
        {
            RecurringJob.AddOrUpdate("RunDemoEvent", () => hangfireEvents.RunDemoTask(), Cron.Minutely);

            return Ok();
        }
    }
}