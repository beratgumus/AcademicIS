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
    public class ProfileFormTests
    {
        [TestMethod()]
        public void ProfileFormTest()
        {
            ProfileForm pF = new ProfileForm(1, false);
            bool editVisibility = pF.GetEditButtonVisibility();
            bool deleteVisibility = pF.GetDeleteButtonVisibility();
            Assert.AreEqual(false, editVisibility);
            Assert.AreEqual(false, deleteVisibility);
        }
    }
}