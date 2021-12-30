using ConsoleWCFClient.ProxyNamespace;
using System;

namespace ConsoleWCFClient
{

    // Run WCF service Host Project as an administrator.
    class Program
    {
        static void Main(string[] args)
        {
            WCFServiceClient Obj = new WCFServiceClient("BasicHttpBinding_IWCFService");
            Console.WriteLine(Obj.Greet("Tashik"));
            Console.ReadLine();
        }
    }
}
