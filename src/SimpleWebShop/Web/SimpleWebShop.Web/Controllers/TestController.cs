using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyNetQ;
using SimpleWebShop.Messages;

namespace SimpleWebShop.Web.Controllers
{
    public class TestController : BaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpPost]
        public ActionResult Publish(string name, int age)
        {
            IBus bus = RabbitHutch.CreateBus("host=localhost");
            var message = new TestMessage()
            {
                Age = age,
                Name = name
            };

            bus.Publish(message);
            return this.Content("Ok");
        }
    }
}