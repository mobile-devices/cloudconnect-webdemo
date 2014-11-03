using CloudConnect.CouchBaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace CloudConnect.WebDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NotificationProvider np = new NotificationProvider();
            IEnumerable<Notification> data = np.RequestNotificationCache("GENERIC", DateTime.UtcNow);

            Console.WriteLine(data.Count());
            //CloudConnect.CouchBaseProvider.CouchbaseManager.RegisterModelViews(new Assembly[] { Assembly.GetAssembly(typeof(CloudConnect.CouchBaseProvider.CouchbaseManager)) });
            //NotificationProvider np = new NotificationProvider();
             
            //System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            //timer.Start();
            //for (int i = 1; i < 10000; i++)
            //{
            //    np.PushNotificationCache("GENERIC", "test" + i.ToString(), DateTime.UtcNow);
            //}
            //timer.Stop();


            //2302
            return View();
        }
    }
}
