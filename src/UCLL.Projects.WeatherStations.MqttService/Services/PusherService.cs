using PusherServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace UCLL.Projects.WeatherStations.MqttService.Services
{
    public class PusherService : Controller
    {
        [HttpPost]
        public async Task<ActionResult> SendStationId(string data)
        {
            var options = new PusherOptions
            {
                Cluster = "eu",
                Encrypted = true
            };

            var pusher = new Pusher(
              "1909710",
              "49d9d357bd1cd6ab9268",
              "b32c743d7f8b9711f7a6",
              options);

            var result = await pusher.TriggerAsync(
              "WheaterStation-Channel",
              "StationId-Event",
              new { message = data });

            return new HttpStatusCodeResult((int)HttpStatusCode.OK);
        }
    }
}
