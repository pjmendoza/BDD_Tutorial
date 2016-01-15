using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutoFrameworkDemo;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        //[TestInitialize]
        //Browser.

        [TestMethod]
        public void LoadHomePage()
        {

            Browser.openBrowswer("http://www.planit.net.au/");
            var index = Home.IndexPage1Heading();
            Assert.AreEqual("Planit Index 2015: Results", index);
        }

         [TestMethod]
        public void LoadContactUsPage()
        {

            Browser.openBrowswer("http://www.planit.net.au/contact/");
            // ContactUs.goToContactUs();
            String textHeaderContactUs = ContactUs.getHeaderContactUs();
            
            ContactUs.setfNameContactUs("PJ");
            ContactUs.setlNameContactUs("MENDOZA");
            ContactUs.setphoneContactUs("12345");
          //  ContactUs.setStateContactUs("NSW");
          //  ContactUs.setDepartmentContactUs("Testing Services");
            ContactUs.clickEnquireContactUs();

            Assert.AreEqual("Contact us", textHeaderContactUs);
            Assert.AreEqual("This field is required.", ContactUs.getErrorMessage());
        }

        [TestCleanup]
        public void close()
        {
           // Browser.closeBrowswer();
        }
    }
}
