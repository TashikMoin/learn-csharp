﻿using System.ServiceModel;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFService" in both code and config file together.
    [ServiceContract]
    // This ServiceContract helps in making this interface as WCF service contract
    public interface IWCFService
    {
        [OperationContract]
        // operational contract decorator makes the methods available to the clients.
        string Greet(string Name);
    }
}

// Run WCF service Host Project as an administrator.

/*
 * Steps
 * 1. Create a class library project in .Net Framework 4.8 and go to add > new item > wcf service and
 * and a new wcf service. After adding a new wcf service, automatically some WCF service references are
 * added and two fiels are created,
 *  a. Interface of the service
 *  b. Service class
 *  
 * 2. Implement/define the functionality of all the methods declared in the interface.
 * 
 * 3. Host this class library webservice in a separate project (windows form, console app etc) by
 * adding reference of this class library webservice.
 * 
 * 4. In the host project, go to add references > assemblies > search "System.ServiceModel" and add 
 * reference of it.
 * 
 * 5. Add a new file of type "application config file" in hostproject.
 * 
 * 6. See app.config file of HostProject, In this file all the required endpoints are defined with
 * the bindings and the service contracts. There is an additional metadata endpoint "mex" for 
 * communication.
 * 
 * 7. Create a client console application project and add reference of this WCF service. Use
 * host URL because it will act as WSDL for the WCF service and finally add the reference of 
 * the service.
 * 
 * 8. Note: The endpoints are not only created on service host but they are also created on client 
 * projects also when we add reference of the service all the endpoints defined in the service host 
 * project, their corresponding endpoints are also defined in client's app.config file. If the
 * WCF service has more than one endpoint definition then clients will also be having the definition 
 * for all the endpoints but a client can only use 1 endpoint to communicate with the WCF service with
 * 1 binding in it. To specify an endpoint, go to app.config of client's project and copy the name of
 * the endpoint through which you want to connect with the service and in the program file, pass that
 * endpoint name to the constructor of the autogenerated proxy class for the communication with the 
 * WCF service. These endpoints on client's project are created when a WCF service reference is added 
 * to a client's project.
 * 
 * 9. Use proxy class instance to access WCF service methods.
 * 
 * 10. In future the same client can use a different endpoint that may have a different communication 
 * and message protocols.
*/
