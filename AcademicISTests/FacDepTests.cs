using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademicIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicIS.Tests
{
    [TestClass()]
    public class FacDepTests
    {

        [TestMethod()]
        public void FacDepEqualsTest()
        {
            FacDep f1 = new FacDep(1, "Mühendislik Fakültesi");
            FacDep f2 = new FacDep(1, "Mühendislik Fakültesi");
            FacDep f3 = new FacDep(2, "Tıp Fakültesi");

            if (!f1.Equals(f2))
                Assert.Fail();

            if(f1.Equals(f3))
                Assert.Fail();
        }
    }
}