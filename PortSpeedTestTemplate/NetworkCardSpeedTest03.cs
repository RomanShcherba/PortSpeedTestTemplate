//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network Card Speed Test 03
    /// </summary>
    public class NetworkCardSpeedTest03 : NetworkCardSpeedTestFlow
    {
        /// <summary>
        /// Name of test
        /// </summary>
        public const string Name = "NetworkCardSpeedTest03";

        /// <summary>
        /// Description of test
        /// </summary>
        public const string Description = "Test with card mode 2";

        /// <summary>
        /// List of data
        /// </summary>
        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
            (mode : 1, new List<(int, int)>
                                 {
                                     (port : 1, speed : 50),
                                     (port : 2, speed : 50)
                                 }),
        };
    }
}
