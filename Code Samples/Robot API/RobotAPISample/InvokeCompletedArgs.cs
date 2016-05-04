using System;
using System.Activities;
using System.Collections.Generic;

namespace RobotAPISample
{
    public class InvokeCompletedArgs : System.EventArgs
    {
        public ActivityInstanceState State { get; set; }

        public Exception Error { get; set; }

        public IDictionary<string, object> Output { get; set; }

        public Guid Token { get; set; }

        public string WorkflowFile { get; set; }

        public InvokeCompletedArgs()
        {

        }
    }
}
