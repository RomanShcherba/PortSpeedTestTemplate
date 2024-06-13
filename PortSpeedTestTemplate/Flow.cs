using log4net;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PortSpeedTestTemplate
{
    public class Flow
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Flow));

        private TestTemplate testTemplate;
        private TestTemplate parameter;

        public void Prepare()
        {
            log.Info("Preparing test");
            testTemplate.Initialize();
        }
        public void Run()
        {
            log.Info("Running test");
        }
        public void Clean()
        {
            log.Info("Cleaning up after test");
            testTemplate.TearDown();

        }
    }
}
