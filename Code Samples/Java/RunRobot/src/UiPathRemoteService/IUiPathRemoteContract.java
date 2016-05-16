/**
 * IUiPathRemoteContract.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package UiPathRemoteService;

public interface IUiPathRemoteContract extends java.rmi.Remote {
    public java.lang.String startJob(java.lang.String jobInfo) throws java.rmi.RemoteException;
    public java.lang.String queryJob(java.lang.String jobId) throws java.rmi.RemoteException;
    public void cancelJob(java.lang.String jobId) throws java.rmi.RemoteException;
    public java.lang.Boolean isAlive() throws java.rmi.RemoteException;
}
