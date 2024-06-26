//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network Card Speed Test 08
    /// </summary>
    public class NetworkCardSpeedTest08 : NetworkCardSpeedTestFlow
    {
        /// <summary>
        /// Name of test
        /// </summary>
        public const string Name = "NetworkCardSpeedTest08";

        /// <summary>
        /// Description of test
        /// </summary>
        public const string Description = "Test with card mode 8";

        /// <summary>
        /// List of data
        /// </summary>
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
    }
}
