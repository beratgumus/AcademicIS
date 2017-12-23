using Microsoft.VisualStudio.TestTools.UnitTesting;
using AcademicIS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicIS.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void ShowProfileFormTest()
        {
            int aId = 1;
            MainForm mF = new MainForm();
            mF.SetIsAdminLoggedIn(true);
            ProfileForm pF = mF.ShowProfileForm(aId);
            bool editVisibility = pF.GetEditButtonVisibility();
            bool deleteVisibility = pF.GetDeleteButtonVisibility();
            int actualId = pF.GetAcId();
            Assert.AreEqual(aId, actualId);
            Assert.AreEqual(true, editVisibility);
            Assert.AreEqual(true, deleteVisibility);
        }
    }
}