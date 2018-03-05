using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfServiceSOAPTeamServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceSOAPTeamServices.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void GetAddressSoapTest()
        {
            
            
                Service1 P = new Service1();
                

                Assert.AreSame(P.GetAddressSoap(), "Addressen");
            
        }

        [TestMethod()]
        public void GetNameSoapTest()
        {
            Service1 P = new Service1();
            Assert.AreSame(P.GetNameSoap(), "Daniel Hahnemann");
        }
    }
}