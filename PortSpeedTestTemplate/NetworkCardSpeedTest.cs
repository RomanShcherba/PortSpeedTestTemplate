using log4net;
using System.Linq;

namespace PortSpeedTestTemplate
{
    public class NetworkCardSpeedTest : NetworkCardSpeedTestFlow
    {
        public NetworkCardSpeedTest(string testName)
            //: base
        {
            TestName = testName;
        }

        public const string Name = "WebCardSpeedTest";

        public const string Description = "Test with mod";

        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new List<(byte mode, List<(int port, int speed)>)>()
        {
            (mode : 1, new List<(int, int)> { (port : 1, speed : 10) } ),

            (mode : 1, new List<(int, int)> { (port : 1, speed : 25) } ),

            (mode : 2, new List<(int, int)> { (port : 1, speed : 50), (port : 2, speed : 50 ) } ),

            (mode : 2, new List<(int, int)> { (port : 1, speed : 25), (port : 2, speed : 50 ) } ),

            (mode : 4, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 25), (port : 3, speed : 50), (port : 4, speed : 10) } ),

            (mode : 4, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 25), (port : 3, speed : 25), (port : 4, speed : 25) } ),

            (mode : 4, new List<(int, int)> { (port : 1, speed : 0), (port : 2, speed : 10), (port : 3, speed : 10), (port : 4, speed : 50) } ),

            (mode : 8, new List<(int, int)> { (port : 1, speed : 0), (port : 2, speed : 10), (port : 3, speed : 0), (port: 4, speed : 10), (port : 5, speed : 10), (port : 6, speed : 10), (port : 7, speed : 50), (port : 8, speed : 0) } ),

            (mode : 8, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 10), (port : 3, speed : 0), (port : 4, speed : 0), (port : 5, speed : 25), (port : 6, speed : 10), (port : 7, speed : 10), (port : 8, speed : 0) } ),

            (mode : 8, new List<(int, int)> { (port : 1, speed : 10), (port : 2, speed : 10), (port : 3, speed : 10), (port : 4, speed : 10), (port : 5, speed : 10), (port : 6, speed : 25), (port : 7, speed : 10), (port : 8, speed : 10) } ),

        };

       

        //public NetworkCardSpeedTestTemplate Parameter => new NetworkCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 10 } });

        //public List<NetworkCardSpeedTest> TestData()
        //{
        //    var test = new List<NetworkCardSpeedTest>();

        //    //var parameter1 = new NetworkCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 10 } });
        //    //test.Add(new NetworkCardSpeedTest(1, "Test 1", "Testing network card with 1 port, with speed 10 Gbps", parameter1));

        //    //var parameter2 = new NetworkCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 25 } });
        //    //test.Add(new NetworkCardSpeedTest(2, "Test 2", "Testing network card with 1 port, with speed 25 Gbps", parameter2));

        //    //var parameter3 = new NetworkCardSpeedTestTemplate(2, new Dictionary<int, int> { { 1, 50 }, { 2, 50 } });
        //    //test.Add(new NetworkCardSpeedTest(3, "Test 3", "Testing network card with 2 port, with speed 100 Gbps", parameter3));

        //    //var parameter4 = new NetworkCardSpeedTestTemplate(2, new Dictionary<int, int> { { 1, 25 }, { 2, 50 } });
        //    //test.Add(new NetworkCardSpeedTest(4, "Test 4", "Testing network card with 2 port, with speed 75 Gbps", parameter4));

        //    //var parameter5 = new NetworkCardSpeedTestTemplate(4, new Dictionary<int, int> { { 1, 10 }, { 2, 25 }, { 3, 50 }, { 4, 10 } });
        //    //test.Add(new NetworkCardSpeedTest(5, "Test 5", "Testing network card with 4 port, with speed 95 Gbps", parameter5));

        //    //var parameter6 = new NetworkCardSpeedTestTemplate(4, new Dictionary<int, int> { { 1, 10 }, { 2, 25 }, { 3, 25 }, { 4, 25 } });
        //    //test.Add(new NetworkCardSpeedTest(6, "Test 6", "Testing network card with 4 port, with speed 85 Gbps", parameter6));

        //    //var parameter7 = new NetworkCardSpeedTestTemplate(4, new Dictionary<int, int> { { 1, 0 }, { 2, 10 }, { 3, 10 }, { 4, 50 } });
        //    //test.Add(new NetworkCardSpeedTest(7, "Test 7", "Testing network card with 4 port, with speed 70 Gbps", parameter7));

        //    //var parameter8 = new NetworkCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 0 }, { 2, 10 }, { 3, 0 }, { 4, 10 }, { 5, 10 }, { 6, 10 }, { 7, 50 }, { 8, 0 } });
        //    //test.Add(new NetworkCardSpeedTest(8, "Test 8", "Testing network card with 8 port, with speed 90 Gbps", parameter8));

        //    //var parameter9 = new NetworkCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 0 }, { 4, 0 }, { 5, 25 }, { 6, 10 }, { 7, 10 }, { 8, 0 }, });
        //    //test.Add(new NetworkCardSpeedTest(9, "Test 9", "Testing network card with 8 port, with speed 65 Gbps", parameter9));

        //    //var parameter10 = new NetworkCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 6, 25 }, { 7, 10 }, { 8, 10 }, });
        //    //test.Add(new NetworkCardSpeedTest(10, "Test 10", "Testing network card with 8 port, with speed 95 Gbps", parameter10));

        //    return test;

        //}
        //public void Execute()
        //{
        //    Console.WriteLine($"Start of test execution: {TestName}, \nDescription: {Description}");
        //    NetworkCardSpeedTestFlow flow = new NetworkCardSpeedTestFlow(parameters.Mode, parameters.PortSpeed);
        //    Prepare();
        //    Run();
        //    Clean();
        //}
    }
}