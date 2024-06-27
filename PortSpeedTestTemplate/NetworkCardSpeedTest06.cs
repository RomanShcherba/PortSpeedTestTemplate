//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network Card Speed Test 06
    /// </summary>
    public class NetworkCardSpeedTest06 : NetworkCardSpeedTestFlow
    {
        /// <summary>
        /// Name of test
        /// </summary>
        public const string Name = "NetworkCardSpeedTest06";

        /// <summary>
        /// Description of test
        /// </summary>
        public const string Description = "Test with card mode 4";

        /// <summary>
        /// List of data
        /// </summary>
        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
            (mode : 1, new List<(int, int)>
                                 {
                                     (port : 1, speed : 10),
                                     (port : 2, speed : 25),
                                     (port : 3, speed : 25),
                                     (port : 4, speed : 25)
                                 }),
        };

    }
}
