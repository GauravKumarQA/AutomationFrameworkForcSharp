using NUnit.Framework;
using NUnitTestFramework.BasePackage;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestFramework.TestCases
{   
    [TestFixture]
    class Testing 
    {

       BaseBrowserSetup setup = new BaseBrowserSetup();
       IWebDriver driver;


        [OneTimeSetUp]
        public void openBrowser()
        {
           driver =  setup.GetDriver();
        }
        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("http://www.google.com");
            Console.WriteLine("Opening browser");
        }

        [Test,Order(2)]
        public void Test2()
        {
            Console.WriteLine("I am test 2");
        }

        [Test,Order(1)]
        public void Test3()
        {
            Console.WriteLine("I am test 3");
        }


    }
}
