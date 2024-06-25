using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSpeedTestTemplate
{
    [TestClass]
    public class Test8 : NetworkCardSpeedTestFlow
    {
        public const string Name = "Test8";
        public const string Description = "Test with card mode 8";

        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
            (mode : 1, new List<(int, int)>
                                 {
                                     (port : 1, speed : 0),
                                     (port : 2, speed : 10),
                                     (port : 3, speed : 0),
                                     (port : 4, speed : 10),
                                     (port : 5, speed : 10),
                                     (port : 6, speed : 10),
                                     (port : 7, speed : 50),
                                     (port : 8, speed : 0)
                                 }),
        };


        [TestMethod]
        public void TestExecution()
        {
            Console.WriteLine("Executing test for mode 8");

            Prepare();

            Run();

            Clean();
        }

        public override bool Prepare()
        {
            Console.WriteLine("\nPreparing test for mode 8");
            CheckActiveCardMode(TestData[0].mode);
            SaveCardMod();
            Reset();
            return true;
        }

        public override void Run()
        {
            Console.WriteLine("\nRunning test for mode 8");

            foreach (var testDataElement in TestData)
            {
                byte mode = testDataElement.mode;
                Console.WriteLine($"\nRunning mode: {mode}");
                Waiting();
                foreach ((int port, int speed) in testDataElement.Item2)
                {
                    SetPortSpeed(port, speed);
                    CheckPortStatus(port);
                }
            }
        }

        public override bool Clean()
        {
            RestoreDefaultMode();
            RestoreDefaultSpeed();
            Console.WriteLine("\nCleaning up after test for mode 8");
            return true;
        }
    }
}
