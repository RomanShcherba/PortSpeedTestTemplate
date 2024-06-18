using log4net;
using System.Linq;

namespace PortSpeedTestTemplate
{
    public class WebCardSpeedTest : WebCardSpeedTestFlow
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(WebCardSpeedTest));

        public WebCardSpeedTest(int testNumber, string testName, string description, WebCardSpeedTestTemplate parameter)
           : base(parameter)
        {
            TestNumber = testNumber;
            Name = testName;
            Description = description;
            Parameters = parameter;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public WebCardSpeedTestTemplate? Parameters { get; set; }
        public int TestNumber { get; set; }
        public int TotalSpeed => Parameters.PortSpeed.Values.Sum();

        public List<WebCardSpeedTest> TestData()
        {
            var test = new List<WebCardSpeedTest>();

            var parameter1 = new WebCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 10 } });
            test.Add(new WebCardSpeedTest(1,  "Test 1", "Testing network card with 1 port, with speed 10 Gbps", parameter1));

            var parameter2 = new WebCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 25 } });
            test.Add(new WebCardSpeedTest(2,  "Test 2", "Testing network card with 1 port, with speed 25 Gbps", parameter2));

            var parameter3 = new WebCardSpeedTestTemplate(2, new Dictionary<int, int> { { 1, 50 }, { 2, 50 } });
            test.Add(new WebCardSpeedTest(3, "Test 3", "Testing network card with 2 port, with speed 100 Gbps", parameter3));

            var parameter4 = new WebCardSpeedTestTemplate(2, new Dictionary<int, int> { { 1, 25 }, { 2, 50 } });
            test.Add(new WebCardSpeedTest(4, "Test 4", "Testing network card with 2 port, with speed 75 Gbps", parameter4));

            var parameter5 = new WebCardSpeedTestTemplate(4, new Dictionary<int, int> { { 1, 10 }, { 2, 25 }, { 3, 50 }, { 4, 10 } });
            test.Add(new WebCardSpeedTest(5, "Test 5", "Testing network card with 4 port, with speed 95 Gbps", parameter5));

            var parameter6 = new WebCardSpeedTestTemplate(4, new Dictionary<int, int> { { 1, 10 }, { 2, 25 }, { 3, 25 }, { 4, 25 } });
            test.Add(new WebCardSpeedTest(6, "Test 6", "Testing network card with 4 port, with speed 85 Gbps", parameter6));

            var parameter7 = new WebCardSpeedTestTemplate(4, new Dictionary<int, int> { { 1, 0 }, { 2, 10 }, { 3, 10 }, { 4, 50 } });
            test.Add(new WebCardSpeedTest(7, "Test 7", "Testing network card with 4 port, with speed 70 Gbps", parameter7));

            var parameter8 = new WebCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 0 }, { 2, 10 }, { 3, 0 }, { 4, 10 }, { 5, 10 }, { 6, 25 }, { 7, 50 }, { 8, 0 } });
            test.Add(new WebCardSpeedTest(8, "Test 8", "Testing network card with 8 port, with speed 90 Gbps", parameter8));

            var parameter9 = new WebCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 0 }, { 4, 0 }, { 5, 25 }, { 6, 10 }, { 7, 10 }, { 8, 0 }, });
            test.Add(new WebCardSpeedTest(9, "Test 9", "Testing network card with 8 port, with speed 65 Gbps", parameter9));

            var parameter10 = new WebCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 6, 25 }, { 7, 10 }, { 8, 10 }, });
            test.Add(new WebCardSpeedTest(10, "Test 10", "Testing network card with 8 port, with speed 95 Gbps", parameter10));

            return test;

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"\nTest Number:{TestNumber}, \nTest Name:{Name}, \nDescription:{Description}, \nMode:{Mode}, \nTotal Speed:{TotalSpeed} ");
            foreach (var port in PortSpeed)
            {
                Console.WriteLine($"Port{port.Key}: {port.Value} Gbps");
            }
        }
    }
}