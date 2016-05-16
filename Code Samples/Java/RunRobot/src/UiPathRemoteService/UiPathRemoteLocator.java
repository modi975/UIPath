/**
 * UiPathRemoteLocator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package UiPathRemoteService;

public class UiPathRemoteLocator extends org.apache.axis.client.Service implements UiPathRemoteService.UiPathRemote {

    public UiPathRemoteLocator() {
    }


    public UiPathRemoteLocator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public UiPathRemoteLocator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for DefaultEndpoint
    private java.lang.String DefaultEndpoint_address = "http://localhost:8080/UiPath/service/agent";

    public java.lang.String getDefaultEndpointAddress() {
        return DefaultEndpoint_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String DefaultEndpointWSDDServiceName = "DefaultEndpoint";

    public java.lang.String getDefaultEndpointWSDDServiceName() {
        return DefaultEndpointWSDDServiceName;
    }

    public void setDefaultEndpointWSDDServiceName(java.lang.String name) {
        DefaultEndpointWSDDServiceName = name;
    }

    public UiPathRemoteService.IUiPathRemoteContract getDefaultEndpoint() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(DefaultEndpoint_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getDefaultEndpoint(endpoint);
    }

    public UiPathRemoteService.IUiPathRemoteContract getDefaultEndpoint(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            UiPathRemoteService.DefaultEndpointStub _stub = new UiPathRemoteService.DefaultEndpointStub(portAddress, this);
            _stub.setPortName(getDefaultEndpointWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setDefaultEndpointEndpointAddress(java.lang.String address) {
        DefaultEndpoint_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (UiPathRemoteService.IUiPathRemoteContract.class.isAssignableFrom(serviceEndpointInterface)) {
                UiPathRemoteService.DefaultEndpointStub _stub = new UiPathRemoteService.DefaultEndpointStub(new java.net.URL(DefaultEndpoint_address), this);
                _stub.setPortName(getDefaultEndpointWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("DefaultEndpoint".equals(inputPortName)) {
            return getDefaultEndpoint();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://tempuri.org/", "UiPathRemote");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://tempuri.org/", "DefaultEndpoint"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("DefaultEndpoint".equals(portName)) {
            setDefaultEndpointEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
