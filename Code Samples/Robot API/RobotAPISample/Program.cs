using System;

namespace RobotAPISample
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RobotClient();
            // Make sure the path to the workflow is correct
            // The workflow project is called RobotAPI and can be found next to the solution file
            var job = @"{'WorkflowFile': 'C:\\Workflows\\RobotAPISample\\RobotAPI\\Main.xaml', 'InputArguments': {'Message': 'Message from RobotAPISample'}, 'User': 'andra', 'Type': 0}";
            Console.WriteLine(client.StartJob(job));
            Console.ReadLine();
        }
    }
}
