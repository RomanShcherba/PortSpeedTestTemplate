using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PortSpeedTestTemplate
{
    public class TestTemplate
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Test));
        public int Mode { get; set; }
        public Dictionary<int, int> PortSpeed { get; set; }

        public TestTemplate(int mode, Dictionary<int, int> portSpeed)
        {
            Mode = mode;
            PortSpeed = portSpeed;
        }
        public List<Test> Parameters()
        {
            var test = new List<Test>();    

            var parameter1 = new TestTemplate(1, new Dictionary<int, int> { { 1, 10 } });
            test.Add(new Test("Test 1", "Testing network card with 1 port, with speed 10 Gbps", parameter1));

            var parameter2 = new TestTemplate(1, new Dictionary<int, int> { { 1, 25 } });
            test.Add(new Test("Test 2", "Testing network card with 1 port, with speed 25 Gbps", parameter2));

            var parameter3 = new TestTemplate(2, new Dictionary<int, int> { { 1, 50 }, {2,50 } });
            test.Add(new Test("Test 3", "Testing network card with 2 port, with speed 100 Gbps", parameter3));

            var parameter4 = new TestTemplate(2, new Dictionary<int, int> { { 1, 25 },{2,50} });
            test.Add(new Test("Test 4", "Testing network card with 2 port, with speed 75 Gbps", parameter4));

            var parameter5 = new TestTemplate(4, new Dictionary<int, int> { { 1, 10 }, { 2, 25 }, { 3, 50 }, { 4, 10 } });
            test.Add(new Test("Test 5", "Testing network card with 4 port, with speed 95 Gbps", parameter5));

            var parameter6 = new TestTemplate(4, new Dictionary<int, int> { { 1, 10 },{ 2, 25 },{ 3, 25 },{ 4, 25 } });
            test.Add(new Test("Test 6", "Testing network card with 4 port, with speed 85 Gbps", parameter6));

            var parameter7 = new TestTemplate(4, new Dictionary<int, int> { { 1, 0 },{ 2, 10 },{ 3, 10 },{ 4, 50 } });
            test.Add(new Test("Test 7", "Testing network card with 4 port, with speed 70 Gbps", parameter7));

            var parameter8 = new TestTemplate(8, new Dictionary<int, int> { { 1, 0 },{ 2, 10 },{ 3, 0 },{ 4, 10 },{ 5, 10 },{ 6, 25 },{ 7, 50 },{ 8, 0 } });
            test.Add(new Test("Test 8", "Testing network card with 8 port, with speed 90 Gbps", parameter8));

            var parameter9 = new TestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 0 }, { 4, 0 }, { 5, 25 }, { 6, 10 }, { 7, 10 }, { 8, 0 }, });
            test.Add(new Test("Test 9", "Testing network card with 8 port, with speed 65 Gbps", parameter9));

            var parameter10 = new TestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 6, 25 }, { 7, 10 }, { 8, 10 }, });
            test.Add(new Test("Test 10", "Testing network card with 8 port, with speed 95 Gbps", parameter10));
            return test;

        }

        public void Initialize()
        {
            log.Info("Initialize test");
        }
        public void TearDown()
        {
            log.Info("Tear down test");
        }
    }
}
