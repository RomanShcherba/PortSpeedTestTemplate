using System;
using System.Collections.Generic;

namespace PortSpeedTestTemplate
{   
    [TestClass]
    public class Test1 : NetworkCardSpeedTestFlow
    {
        public const string Name = "Test1";
        public const string Description = "Test with card mode 1";

        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
            (mode: 1, new List<(int, int)> 
                                 { 
                                      (port: 1, speed: 10) 
                                 }),
        };

        [TestMethod]
        public void TestExecution()
        {
            Console.WriteLine("Executing test for mode 1");

            Prepare();

            Run();

            Clean();
        }

        public override bool Prepare()
        {
            Console.WriteLine("\nPreparing test for mode 1");
            CheckActiveCardMode(TestData[0].mode);
            SaveCardMod();
            Reset();
            return true;
        }

        public override void Run()
        {
            Console.WriteLine("\nRunning test for mode 1");

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
            Console.WriteLine("\nCleaning up after test for mode 1");
            return true;
        }
    }
}
