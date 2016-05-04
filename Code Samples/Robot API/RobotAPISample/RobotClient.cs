using Newtonsoft.Json;
using RobotAPISample.RobotAPI;
using System;
using System.IO;
using System.ServiceModel;

namespace RobotAPISample
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, UseSynchronizationContext = false)]
    public class RobotClient : IUiPathRemoteDuplexContractCallback
    {
        // UiPath Remote Channel
        protected IUiPathRemoteDuplexContract Channel = null;
        protected DuplexChannelFactory<IUiPathRemoteDuplexContract> DuplexChannelFactory = null;

        public RobotClient()
        {
            // Initilize communication channel
            DuplexChannelFactory = new DuplexChannelFactory<IUiPathRemoteDuplexContract>(new InstanceContext(this), "DefaultDuplexEndpoint");
            DuplexChannelFactory.Credentials.Windows.AllowedImpersonationLevel = System.Security.Principal.TokenImpersonationLevel.Impersonation;
            Channel = DuplexChannelFactory.CreateChannel();
        }

        #region Service methods

        public Guid StartJob(string serializedJob)
        {
            return Guid.Parse(Channel.StartJob(SerializeStringToStream(serializedJob)));
        }

        public static Stream SerializeStringToStream(string jobValue)
        {
            if (jobValue == null) return null;

            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(jobValue);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public void CancelJob(Guid jobId)
        {
            Channel.CancelJob(JsonConvert.SerializeObject(jobId));
        }

        #endregion

        #region Duplex callbacks

        public bool OnTrackReceived(string serializedTrackingRecord)
        {
            return false;
        }

        public void OnJobCompleted(string invokeCompletedInfo)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.None
            };

            var completedResult = JsonConvert.DeserializeObject<InvokeCompletedArgs>(invokeCompletedInfo, settings);
            if(completedResult.State == System.Activities.ActivityInstanceState.Faulted)
            {
                Console.WriteLine(completedResult.Error.Message);
                return;
            }
            else if(completedResult.State ==  System.Activities.ActivityInstanceState.Canceled)
            {
                Console.WriteLine("Process cancelled");
            }
            else
            {
                if(completedResult.Output != null)
                {
                    foreach(var output in completedResult.Output)
                    {
                        try
                        {
                            Console.WriteLine(output.Key + ": " + output.Value.ToString());
                        }
                        catch { }
                    }
                   
                }
                Console.WriteLine("Completed without errors");
            }
        }

        public void OnLog(string logMessage)
        {
        }

        #endregion Duplex callbacks
    }
}
