using log4net;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortSpeedTestTemplate
{
    public class Test
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Test));
        public string Name { get; set; }
        public string Description { get; set; }
        public TestTemplate? Parameters { get; set; }


        public Test(string testName, string description, TestTemplate parameter)
        {
            Name = testName;
            Description = description;
            Parameters = parameter;
        }

        public string TestName { get; }

    }
}
