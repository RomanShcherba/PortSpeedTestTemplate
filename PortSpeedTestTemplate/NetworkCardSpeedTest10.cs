﻿//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network Card Speed Test 10
    /// </summary>
    public class NetworkCardSpeedTest10 : NetworkCardSpeedTestFlow
    {
        /// <summary>
        /// Name of test
        /// </summary>
        public const string Name = "NetworkCardSpeedTest10";

        /// <summary>
        /// Description of test
        /// </summary>
        public const string Description = "Test with card mode 8";

        /// <summary>
        /// List of data
        /// </summary>
        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
            (mode : 8, new List<(int, int)>
                                 {
                                     (port : 1, speed : 10),
                                     (port : 2, speed : 10),
                                     (port : 3, speed : 10),
                                     (port : 4, speed : 10),
                                     (port : 5, speed : 10),
                                     (port : 6, speed : 25),
                                     (port : 7, speed : 10),
                                     (port : 8, speed : 10)
                                 })
        };
    }
}
