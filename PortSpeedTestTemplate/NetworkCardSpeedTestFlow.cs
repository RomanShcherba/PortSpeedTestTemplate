
namespace PortSpeedTestTemplate
{

    public class NetworkCardSpeedTestFlow : NetworkCardSpeedTestTemplate
    {
        protected readonly NetworkCardSpeedTestTemplate parameters;
 
        //public NetworkCardSpeedTestFlow(string testName)
        //   : base()
        //{
        //    this.parameters = parameters;
        //    TestName = testName;
        //}

        //public NetworkCardSpeedTestFlow(int mode, Dictionary<int, int> portSpeed) : base(mode, portSpeed)
        //{

        //}

        public override bool Prepare()
        {
            Console.WriteLine("Preparing test");
            return true;
        }

        public override void Run()
        {
            Console.WriteLine("Running test");
            foreach ((int port, int speed) in TestData[0].Item2)
            {
                SetPortSpeed(port, port);
                CheckPortStatus(port);
            }
        }


        public override bool Clean()
        {
            Console.WriteLine("Cleaning up after test");
            return true;
        }
    }
}
