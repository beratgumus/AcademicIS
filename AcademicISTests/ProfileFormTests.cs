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
            int aId =1;
            ProfileForm pF = new ProfileForm(aId, false);
            bool editVisibility = pF.GetEditButtonVisibility();
            bool deleteVisibility = pF.GetDeleteButtonVisibility();
            int actualId = pF.GetAcId();
            Assert.AreEqual(aId, actualId);
            Assert.AreEqual(false, editVisibility);
            Assert.AreEqual(false, deleteVisibility); 
        }
    }
}