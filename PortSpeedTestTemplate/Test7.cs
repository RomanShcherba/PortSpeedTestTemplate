﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSpeedTestTemplate
{
    [TestClass]
    public class Test7 : NetworkCardSpeedTestFlow
    {
        public const string Name = "Test7";
        public const string Description = "Test with card mode 7";

        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
            (mode : 1, new List<(int, int)>
                                 {
                                     (port : 1, speed : 0),
                                     (port : 2, speed : 10),
                                     (port : 3, speed : 10),
                                     (port : 4, speed : 50)
                                 }),
        };



        [TestMethod]
        public void TestExecution()
        {
            Console.WriteLine("Executing test for mode 7");

            Prepare();

            Run();

            Clean();
        }

        public override bool Prepare()
        {
            Console.WriteLine("\nPreparing test for mode 7");
            CheckActiveCardMode(TestData[0].mode);
            SaveCardMod();
            Reset();
            return true;
        }

        public override void Run()
        {
            Console.WriteLine("\nRunning test for mode 7");

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
            Console.WriteLine("\nCleaning up after test for mode 7");
            return true;
        }
    }
}
