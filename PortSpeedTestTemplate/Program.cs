using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System.Reflection;

namespace PortSpeedTestTemplate
{

    public abstract class Program
    {
        static void Main()
        {
            string testName = "NetworkCardSpeedTest";

            string className = $"PortSpeedTestTemplate.{testName}";

            Execute(className);
        }



        public static void Execute(string className)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type? type = assembly.GetType(className);

            if (type != null)
            {
                object instance = Activator.CreateInstance(type);

                string fieldName = (string)type.GetField("Name").GetValue(instance);
                string fieldDescription = (string)type.GetField("Description").GetValue(instance);

                Console.WriteLine($"Start of test execution: {fieldName} \nDescription: {fieldDescription}");

                MethodInfo prepare = type.GetMethod("Prepare");
                MethodInfo run = type.GetMethod("Run");
                MethodInfo clean = type.GetMethod("Clean");

                if (prepare != null && run != null && clean != null)
                {
                    prepare.Invoke(instance, null);
                    run.Invoke(instance, null);
                    clean.Invoke(instance, null);
                }

            }
            else
            {
                Console.WriteLine($"There is no such test: {className}");
            }
        }
    }
}