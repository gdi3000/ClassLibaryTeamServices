﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceSOAPTeamServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetAddressSoap()
        {
           return "Addressen";
        }

        public string GetNameSoap()
        {
            return "Daniel Hahnemann";
        }
    }
}
