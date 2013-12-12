using System;
using System.Activities.XamlIntegration;
using System.IO;
using System.Activities;

namespace WorkflowSample
{

    class Program
    {

        // Before running this sample, please add UiPath package from NuGet
        // You can find more info about this here : https://github.com/Deskover/UiPath/wiki/Development-with-API#wiki-Using_NuGet_package_manager

        static void Main(string[] args)
        {
            var workflowText = Properties.Resources.Workflow;
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(workflowText);
            writer.Flush();
            stream.Position = 0;
            var invoker = new WorkflowInvoker(ActivityXamlServices.Load(stream));
            invoker.Invoke();
        }
    }
}
