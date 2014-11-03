using CloudConnect.CouchBaseProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CloudConnect.WebDemo.Controllers
{
    public class NotificationsController : ApiController
    {
        // POST api/notifications
        public void Post([FromBody]string value)
        {
            NotificationProvider np = new NotificationProvider();
            np.PushNotificationCache("GENERIC", value, DateTime.UtcNow);
        }
    }
}
