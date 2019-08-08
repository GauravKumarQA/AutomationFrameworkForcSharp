using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestFramework.BasePackage
{
    
    class BaseBrowserSetup
    {

        
        public IWebDriver GetDriver()
        {
            String browserName = "chrome";
            if (browserName == null)
            {
                browserName = "chrome";
            }

            switch (browserName)
            {
               
                case "chrome" : return ChromeDriver();

                case "firefox": return FirefoxDriver();

                default: return null;
            }
           
        }


        private IWebDriver ChromeDriver()
        {
            IWebDriver chromeDriver = new ChromeDriver(@"C:/");
            return chromeDriver;
        }

        private IWebDriver FirefoxDriver()
        {
            IWebDriver chromeDriver = new FirefoxDriver();
            return chromeDriver;
        }


    }
}
