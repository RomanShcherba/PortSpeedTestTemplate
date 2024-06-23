
using System.Collections.Generic;

namespace PortSpeedTestTemplate
{

    public class NetworkCardSpeedTestFlow : NetworkCardSpeedTestTemplate
    {
        public override bool Prepare()
        {
            Console.WriteLine("Preparing test");
            return true;
        }
        //List<(byte mode, List<(int port, int speed)>)> TestData
        //List <int> TestData
        public override void Run()
        {
            Console.WriteLine("Running test");

            foreach (var testDataElement in TestData)
            {
                byte mode = testDataElement.mode;
                Console.WriteLine($"Running mode: {mode}");
                foreach ((int port, int speed) in testDataElement.Item2)
                {
                    SetPortSpeed(port, speed);
                    CheckPortStatus(port);

                }
            }
        }
        public override bool Clean()
        {
            Console.WriteLine("Cleaning up after test");
            return true;
        }
    }
}
