using log4net;
using System.Linq;

namespace PortSpeedTestTemplate
{
    public class NetworkCardSpeedTest : NetworkCardSpeedTestFlow
    {

        public const string Name = "WebCardSpeedTest";

        public const string Description = "Test with mod";

        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new List<(byte mode, List<(int port, int speed)>)>()
        {
             (mode : 1, new List<(int, int)> { (port : 1, speed : 10) } ),

             (mode : 1, new List<(int, int)> { (port : 1, speed : 25) } ),

             (mode : 2, new List<(int, int)> { (port : 1, speed : 50), (port : 2, speed : 50) }),

             (mode : 2, new List<(int, int)> { (port : 1, speed : 25), (port : 2, speed : 50) }),

             (mode : 4, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 25), (port : 3, speed : 50), (port : 4, speed : 10 ) }),

             (mode : 4, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 25), (port : 3, speed : 25), (port : 4, speed : 25 ) }),

             (mode : 4, new List<(int, int)> { (port : 1, speed : 0), (port : 2, speed : 10), (port : 3, speed : 10), (port : 4, speed : 50 ) }),

             (mode : 8, new List<(int, int)> { (port : 1, speed : 0), (port : 2, speed : 10), (port : 3, speed : 0), (port : 4, speed : 10), (port : 5, speed : 10), (port : 6, speed : 10), (port : 7, speed : 50), (port : 8, speed : 0) }),

             (mode : 8, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 10), (port : 3, speed : 0), (port : 4, speed : 0), (port : 5, speed : 25), (port : 6, speed : 10), (port : 7, speed : 10), (port : 8, speed : 0) }),

             (mode : 8, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 10), (port : 3, speed : 10), (port : 4, speed : 10), (port : 5, speed : 10), (port : 6, speed : 25), (port : 7, speed : 10), (port : 8, speed : 10) })
        
        };
    }
}