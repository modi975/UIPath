How to run a job from Java

1. Enable UiPath Remote as SOAP service configuration in UiPath.Launcher.exe.config
2. Run in an elevated cmd line the following command
   UiLauncher.exe /service /install
3. Run the Java code from this sample


Remarks

If you change the address where the service is exposed you need to regenerate the Web Service Client files
