using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSpeedTestTemplate
{
    public class Program
    {
        static void Main()
        {
            WebCardSpeedTest webCardSpeedTest = new WebCardSpeedTest(0, "Test", "Description", new WebCardSpeedTestTemplate(1, new Dictionary<int, int>()));
            var tests = webCardSpeedTest.TestData();

            foreach (var test in tests)
            {
                test.DisplayInfo();
                test.Execute();
                Console.WriteLine();
            }
        }
    }
}
