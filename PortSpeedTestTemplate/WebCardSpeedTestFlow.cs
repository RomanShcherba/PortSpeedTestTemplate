
using log4net;

namespace PortSpeedTestTemplate
{
    public class WebCardSpeedTestFlow : WebCardSpeedTestTemplate
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(WebCardSpeedTest));
        private WebCardSpeedTestTemplate parameters;

        public string TestName { get; set; }
        public string Description { get; set; }

        public int TestNumber {  get; set; }

        public WebCardSpeedTestFlow(WebCardSpeedTestTemplate parameters) : base(parameters.Mode, parameters.PortSpeed) => this.parameters = parameters;

        public void Prepare()
        {
            log.Info("Preparing test");
            Initialize();

        }
        public void Run()
        {
            log.Info("Running test");
            foreach (var port in parameters.PortSpeed)
            {
                parameters.SetPortSpeed(port.Key, port.Value);
                parameters.CheckPortStatus(port.Key);
            }
        }
        public void Clean()
        {
            log.Info("Cleaning up after test");
            TearDown();
        }

        public void Execute()
        {
            log.Info($"Executing test {TestName} - {Description}");
            WebCardSpeedTestFlow flow = new WebCardSpeedTestFlow(parameters);
            flow.Prepare();
            flow.Run();
            flow.Clean();
        }
    }
}
