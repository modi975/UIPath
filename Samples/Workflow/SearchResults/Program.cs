using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;
using System.Activities.XamlIntegration;


namespace SearchResults
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Text to search: ");
                String searchExp = Console.ReadLine();

                WorkflowInvoker invoker = new WorkflowInvoker(ActivityXamlServices.Load(@"search.uiwf"));
                var arguments = new Dictionary<string, object>();
                arguments.Add("search", searchExp);

                IDictionary<string, object> outArgs = invoker.Invoke(arguments);

                List<KeyValuePair<String, String>> result = (List<KeyValuePair<String, String>>)outArgs["result"];
                foreach (var r in result)
                {
                    Console.WriteLine(r.Key + "\n" + r.Value + "\n\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
            }
        }
    }
}
