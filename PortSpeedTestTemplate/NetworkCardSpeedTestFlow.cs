//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network card speed test flow 
    /// </summary>
    public class NetworkCardSpeedTestFlow : NetworkCardSpeedTestTemplate
    {
        #region Public methods
        /// <summary>
        /// Prepare for test
        /// </summary>
        /// <returns></returns>
        public override bool Prepare()
        {
            Console.WriteLine("\nPreparing test");
            byte mode = TestData[0].mode;
            CheckActiveCardMode(mode);
            SaveCardMod();
            Reset();
            return true;
        }

        /// <summary>
        /// Test run
        /// </summary>
        public override void Run()
        {
            Console.WriteLine("\nRunning test[");

            foreach (var testDataElement in TestData)
            {
                byte mode = testDataElement.mode;
                Console.WriteLine($"\nRunning mode: {mode}");
                Waiting();
                Console.WriteLine();
                foreach ((int port, int speed) in testDataElement.Item2)
                {
                    SetPortSpeed(port, speed);
                    Console.WriteLine();
                    CheckPortStatus(port);
                }
            }
        }

        /// <summary>
        /// Clean after test
        /// </summary>
        /// <returns></returns>
        public override bool Clean()
        {
            RestoreDefaultMode();
            RestoreDefaultSpeed();
            Console.WriteLine("\nCleaning up after test");
            return true;
        }
        #endregion
    }
}