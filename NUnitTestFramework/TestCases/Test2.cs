using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitTestFramework.BasePackage;

namespace NUnitTestFramework.TestCases
{
    [TestFixture]
    class Test2
    {
        [Test]
        public void test4()
        {
            BaseBrowserSetup bs = new BaseBrowserSetup();
            bs.GetDriver().Navigate().GoToUrl("http:google.com");
            
        }

    }
}
