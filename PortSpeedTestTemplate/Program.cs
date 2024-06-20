using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace PortSpeedTestTemplate
{

    public abstract class Program
    {
        static void Main()
        {
            string testName = "NetworkCardSpeedTest";
            //Type t = Type.GetType(testName);
            //var testClassName = (NetworkCardSpeedTest)Activator.CreateInstance(t);
            NetworkCardSpeedTest testClassName = new NetworkCardSpeedTest(testName);
            testClassName.Execute(testClassName);
            
            
            //Test2("Test 2");
            //Test10("Test 10");
        }
        
        
        //static void Test1 (string testName)
        //{
        //    NetworkCardSpeedTestTemplate parameters = new NetworkCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 10 } });
        //    NetworkCardSpeedTest networkCardSpeedTest = new NetworkCardSpeedTest(testName, parameters);

        //    //networkCardSpeedTest.Execute();
        //}

        //static void Test2(string testName)
        //{
        //    NetworkCardSpeedTestTemplate parameters = new NetworkCardSpeedTestTemplate(1, new Dictionary<int, int> { { 1, 25 } });
        //    NetworkCardSpeedTest networkCardSpeedTest = new NetworkCardSpeedTest(testName, parameters);
        //    //networkCardSpeedTest.Execute();
        //}

        //static void Test10 (string testName)
        //{
        //    NetworkCardSpeedTestTemplate parameters = new NetworkCardSpeedTestTemplate(8, new Dictionary<int, int> { { 1, 10 }, { 2, 10 }, { 3, 10 }, { 4, 10 }, { 5, 10 }, { 6, 25 }, { 7, 10 }, { 8, 10 }, });
        //    NetworkCardSpeedTest networkCardSpeedTest = new NetworkCardSpeedTest(testName, parameters);
        //    //networkCardSpeedTest.Execute();
        //}
        public void Execute(NetworkCardSpeedTest test)
        {
            Console.WriteLine($"Start of test execution: {test.TestName}, \nDescription: {test.TestDescription}");
            //NetworkCardSpeedTestFlow flow = new NetworkCardSpeedTestFlow(parameters.Mode, parameters.PortSpeed);
            test.Prepare();
            test.Run();
            test.Clean();
        }
        public void DisplayInfo(string testName)
        {
            Console.WriteLine($"\nTest Name:{testName}");
        }
    }
}
