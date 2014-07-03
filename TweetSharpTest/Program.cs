using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace TweetSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TwitterService service = new TwitterService("BzsXrPMZaWU8SJ5vQHjmfnKcg", "OICVoycfnUEdjyeMJG2eknlc5eUnK24Imu0roR896OJuGn3N3j");
            service.AuthenticateWith("1564029018-0cSKOuMU598BaMydCydgxdLuO3D7ZcUdnY09wb8", "B1kIY8aWOT2t0VRLmBgRVu2B1LvC180nXqsdisJcD7jkS");

            IEnumerable<TwitterStatus> mentions = service.ListTweetsOnHomeTimeline(new ListTweetsOnHomeTimelineOptions());
        }
    }
}
