
using log4net;

namespace PortSpeedTestTemplate
{
    public class WebCardSpeedTestTemplate
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(WebCardSpeedTest));
        public int Mode { get; set; }
        public Dictionary<int, int> PortSpeed { get; set; }

        public WebCardSpeedTestTemplate(int mode, Dictionary<int, int> portSpeed)
        {
            Mode = mode;
            PortSpeed = portSpeed;
        }

        public void Initialize()
        {
            log.Info("Initialize test");
        }
        public void SetPortSpeed(int portNumber, int portSeed)
        {
            log.Info($"Setting port speed {portNumber} to {portSeed}");
        }
        public void CheckPortStatus(int portNumber)
        {
            log.Info("Checking status of port");
        }
        public void TearDown()
        {
            log.Info("Tear down test");
        }
    }
}