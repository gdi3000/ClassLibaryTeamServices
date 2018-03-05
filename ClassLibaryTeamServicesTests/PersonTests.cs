using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibaryTeamServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibaryTeamServices.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void SuccessfulGetNameTest()
        {
            Person P = new Person();
            P.GetName();

            Assert.AreSame(P.GetName(),"Daniel Hahnemann");
        }

        [TestMethod()]
        public void UnsuccessfulGetNameTest()
        {
            Person P = new Person();
            P.GetName();

            Assert.AreNotEqual(P.GetName(), "Bob");
        }

        [TestMethod()]
        public void SuccessfulGetAddressTest()
        {
            Person P = new Person();
            P.GetAddress();

            Assert.AreSame(P.GetAddress(), "Elisagaardsvej 5");
        }

        public void UnsuccessfulGetAddressTest()
        {
            Person P = new Person();
            P.GetAddress();

            Assert.AreNotEqual(P.GetAddress(), "");
        }
    }
}