package jexecuteworkflow;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;


public class JExecuteWorkflow {
    public static void main(String[] args) {
        // Change launcherPath and workflowPath (or take them from command line arguments).
        String launcherPath = "E:\\Projects\\Scraping\\Output\\bin\\Debug\\UiLauncher.exe";
        String workflowPath = "C:\\Users\\adrian\\Documents\\UiPath\\java-invoke\\java-invoke.xaml";
        
        try
        {
            // Launch the workflow.
            Process myProcess = new ProcessBuilder(launcherPath, workflowPath).start();
            myProcess.waitFor();
            
            // Get the output of the workflow.
            BufferedReader stdInput = new BufferedReader(new InputStreamReader(myProcess.getInputStream()));
            String s = null;
            while ((s = stdInput.readLine()) != null) {
                System.out.println(s);
            }
        }
        catch (IOException ex)
        {
        }
        catch (InterruptedException ex)
        {
        }
    }
}
