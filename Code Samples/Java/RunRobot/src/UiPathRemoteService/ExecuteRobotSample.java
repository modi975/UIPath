package UiPathRemoteService;

import java.rmi.RemoteException;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;
import org.json.simple.parser.ParseException;

public class ExecuteRobotSample {
	public static void main(String[] args)
	{
		IUiPathRemoteContractProxy proxy = new IUiPathRemoteContractProxy();
		try {
			
			// TODO: Create Job info
			String workflowPath = "D:\\\\Java\\\\InvokeRobot\\\\RunRobot\\\\SampleRobot.xaml";
			java.lang.String jobInfo  = "{\"WorkflowFile\":\"" + workflowPath + "\",\"InputArguments\":null,\"Debug\":false,\"VerboseDebugging\":false,\"User\":null,\"Password\":null,\"CredentialTarget\":null,\"Type\":0,\"Extension\":null,\"IsChildWorkflow\":false,\"SessionInfo\":null,\"ParentId\":\"00000000-0000-0000-0000-000000000000\",\"RunAsRobot\":false,\"SMAJobId\":\"00000000-0000-0000-0000-000000000000\",\"RobotType\":null,\"Id\":\"00000000-0000-0000-0000-000000000000\"}";
			
			// Call StartJob method	 
			String jobId = proxy.startJob(jobInfo);		
			
			// TODO: Wait job completed
			JSONParser parser = new JSONParser();
			String jobStatus = proxy.queryJob(jobId);
			JSONObject jsonJobStatus = (JSONObject)parser.parse(jobStatus);
			String status = jsonJobStatus.get("Status").toString();
			while(status != "Error" && status != "Finished")
			{
				Thread.sleep(1000);
				jobStatus = proxy.queryJob(jobId);
				jsonJobStatus = (JSONObject)parser.parse(jobStatus);
				status = jsonJobStatus.get("Error").toString();
			}	
						
		} catch (RemoteException | ParseException | InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
