
using log4net;

namespace PortSpeedTestTemplate
{
    public abstract class NetworkCardSpeedTestTemplate : Program
    {
        //public string TestDescription { get; set; }

        //public string TestName { get; set; }

        protected virtual List<(byte mode, List<(int port, int speed)>)> TestData { get; set; }

        //public NetworkCardSpeedTestTemplate(int mode, Dictionary<int, int> portSpeed)
        //{
        //    Mode = mode;
        //    PortSpeed = portSpeed;
        //}

        public void CheckActiveCardMode(byte mode)
        {
            Console.WriteLine($"Active card mode {mode} ");
        }
        public void CheckEachSpeed(int mode, Dictionary<int, int> portSpeed)
        {
            Console.WriteLine($"Port speed{mode}, {portSpeed}");

        }
        public void RestoreDefaultMode()
        {
            Console.WriteLine("Restore default mode");
        }
        public void RestoreDefaultSpeed() 
        {
            Console.WriteLine("Restore default speed");
        }
        public void Waiting()
        {
            Console.WriteLine("Waiting time 3 secs");
        }

        public void SetCardMode(byte mode)
        {
            Console.WriteLine($"Card mode {mode}");
        }
        public void Reset()
        {
            Console.WriteLine("Reset");
        }

        public string Initialize() => "Initialize test";
       

        public void SetPortSpeed(int portNumber, int portSeed)
        {
            Console.WriteLine($"Setting port speed {portNumber} to {portSeed}");
        }
      
        public void CheckPortStatus(int portNumber)
        {
            Console.WriteLine($"Checking status of port{portNumber}");
        }

        public string TearDown() => "Tear down test";

        public abstract bool Prepare();

        public abstract void Run();

        public abstract bool Clean();
    }
}