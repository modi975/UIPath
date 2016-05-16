package UiPathRemoteService;

public class IUiPathRemoteContractProxy implements UiPathRemoteService.IUiPathRemoteContract {
  private String _endpoint = null;
  private UiPathRemoteService.IUiPathRemoteContract iUiPathRemoteContract = null;
  
  public IUiPathRemoteContractProxy() {
    _initIUiPathRemoteContractProxy();
  }
  
  public IUiPathRemoteContractProxy(String endpoint) {
    _endpoint = endpoint;
    _initIUiPathRemoteContractProxy();
  }
  
  private void _initIUiPathRemoteContractProxy() {
    try {
      iUiPathRemoteContract = (new UiPathRemoteService.UiPathRemoteLocator()).getDefaultEndpoint();
      if (iUiPathRemoteContract != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)iUiPathRemoteContract)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)iUiPathRemoteContract)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (iUiPathRemoteContract != null)
      ((javax.xml.rpc.Stub)iUiPathRemoteContract)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public UiPathRemoteService.IUiPathRemoteContract getIUiPathRemoteContract() {
    if (iUiPathRemoteContract == null)
      _initIUiPathRemoteContractProxy();
    return iUiPathRemoteContract;
  }
  
  public java.lang.String startJob(java.lang.String jobInfo) throws java.rmi.RemoteException{
    if (iUiPathRemoteContract == null)
      _initIUiPathRemoteContractProxy();
    return iUiPathRemoteContract.startJob(jobInfo);
  }
  
  public java.lang.String queryJob(java.lang.String jobId) throws java.rmi.RemoteException{
    if (iUiPathRemoteContract == null)
      _initIUiPathRemoteContractProxy();
    return iUiPathRemoteContract.queryJob(jobId);
  }
  
  public void cancelJob(java.lang.String jobId) throws java.rmi.RemoteException{
    if (iUiPathRemoteContract == null)
      _initIUiPathRemoteContractProxy();
    iUiPathRemoteContract.cancelJob(jobId);
  }
  
  public java.lang.Boolean isAlive() throws java.rmi.RemoteException{
    if (iUiPathRemoteContract == null)
      _initIUiPathRemoteContractProxy();
    return iUiPathRemoteContract.isAlive();
  }
  
  
}