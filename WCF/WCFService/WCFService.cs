using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFService" in both code and config file together.
    public class WCFService : IWCFService
    {
        public string Greet(string Name)
        {
            return "Hello, " + Name;
        }
    }
}
