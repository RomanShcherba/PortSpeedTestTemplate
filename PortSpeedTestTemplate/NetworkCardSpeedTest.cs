//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network card speed test 
    /// </summary> 
    public class NetworkCardSpeedTest : NetworkCardSpeedTestFlow
    {
        #region Fields

        /// <summary>
        /// Name of test
        /// </summary>
        public const string Name = "NetworkCardSpeedTest";

        /// <summary>
        /// Description of test
        /// </summary>
        public const string Description = "Test with mode";

        #endregion

        #region Data set
        /// <summary>
        /// Tuple of dataset
        /// </summary>
        protected override List<(byte mode, List<(int port, int speed)>)> TestData => new()
        {
         (mode : 1, new List<(int, int)>
                                 {
                                     (port : 1, speed : 10)
                                 }),

         (mode : 1, new List<(int, int)>
                                 {
                                     (port : 1, speed : 25)
                                 }),

         (mode : 2, new List<(int, int)>
                                 {
                                     (port : 1, speed : 50),
                                     (port : 2, speed : 50)
                                 }),

         (mode : 2, new List<(int, int)>
                                 {
                                     (port : 1, speed : 25),
                                     (port : 2, speed : 50)
                                 }),

         (mode : 4, new List<(int, int)>
                                 {
                                     (port : 1, speed : 10),
                                     (port : 2, speed : 25),
                                     (port : 3, speed : 50),
                                     (port : 4, speed : 10 )
                                 }),

         (mode : 4, new List<(int, int)>
                                 {
                                     (port : 1, speed : 10),
                                     (port : 2, speed : 25),
                                     (port : 3, speed : 25),
                                     (port : 4, speed : 25)
                                 }),

         (mode : 4, new List<(int, int)>
                                 {
                                     (port : 1, speed : 0),
                                     (port : 2, speed : 10),
                                     (port : 3, speed : 10),
                                     (port : 4, speed : 50)
                                 }),

         (mode : 8, new List<(int, int)>
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

         (mode : 8, new List<(int, int)>
                                 {
                                     (port : 1, speed : 10),
                                     (port : 2, speed : 10),
                                     (port : 3, speed : 0),
                                     (port : 4, speed : 0),
                                     (port : 5, speed : 25),
                                     (port : 6, speed : 10),
                                     (port : 7, speed : 10),
                                     (port : 8, speed : 0)
                                 }),

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
        #endregion
    }
}