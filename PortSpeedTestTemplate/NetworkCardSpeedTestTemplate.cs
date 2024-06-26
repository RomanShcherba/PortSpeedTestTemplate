//Company's property 2024

namespace PortSpeedTestTemplate
{
    /// <summary>
    /// Network card speed test template
    /// </summary>
    public abstract class NetworkCardSpeedTestTemplate : Program
    {
        #region Properties

        /// <summary>
        /// Property
        /// </summary>
        protected virtual List<(byte mode, List<(int port, int speed)>)> TestData { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Prepare
        /// </summary>
        /// <returns></returns>
        public abstract bool Prepare();

        /// <summary>
        /// Runner
        /// </summary>
        public abstract void Run();

        /// <summary>
        /// Cleaner after tests
        /// </summary>
        /// <returns></returns>
        public abstract bool Clean();

        #endregion

        #region Protected methods

        /// <summary>
        /// Active card mode
        /// </summary>
        /// <param name="mode">
        /// Card mode
        /// </param>
        protected static void CheckActiveCardMode(byte mode)
        {
            Console.WriteLine($"\nActive card mode {mode} ");
        }

        /// <summary>
        /// Speed of ports
        /// </summary>
        /// <param name="port">
        /// Port
        /// </param>
        /// <param name="speed">
        /// speed
        /// </param>
        protected static void CheckEachSpeed(int port, int speed) //CHECK SPEED FOR EACH PORT
        {
            Console.WriteLine($"\nPort speed{port}, {speed}");

        }

        /// <summary>
        /// Saving active mode
        /// </summary>
        protected static void SaveCardMod()
        {
            Console.WriteLine("\nSave active card mode");
        }

        /// <summary>
        /// Restore to default mod
        /// </summary>
        protected static void RestoreDefaultMode()
        {
            Console.WriteLine("\nRestore default mode");
        }

        /// <summary>
        /// Restore to default speed
        /// </summary>
        protected static void RestoreDefaultSpeed()
        {
            Console.WriteLine("\nRestore default speed");
        }

        /// <summary>
        /// Waiting after restart
        /// </summary>
        protected static void Waiting()
        {
            Console.WriteLine("\nWaiting time 3 secs");
        }

        /// <summary>
        /// Setting card mode
        /// </summary>
        /// <param name="mode">
        /// Card mode
        /// </param>
        protected static void SetCardMode(byte mode)
        {
            Console.WriteLine($"\nCard mode {mode}");
        }

        /// <summary>
        /// Reset
        /// </summary>
        protected static void Reset()
        {
            Console.WriteLine("\nReseted");
        }

        /// <summary>
        /// Setting port speed
        /// </summary>
        /// <param name="portNumber">
        /// Number of port
        /// </param>
        /// <param name="portSeed">
        /// Speed of port
        /// </param>
        protected static void SetPortSpeed(int portNumber, int portSeed)
        {
            Console.WriteLine($"\nSetting port speed {portNumber} to {portSeed}");
        }

        /// <summary>
        /// Status of port
        /// </summary>
        /// <param name="portNumber">
        /// Number of port
        /// </param>
        protected static void CheckPortStatus(int portNumber)
        {
            Console.WriteLine($"\nChecking status of port{portNumber}");
        }

        #endregion
    }
}