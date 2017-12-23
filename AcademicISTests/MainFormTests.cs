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
            MainForm mF = new MainForm();
            mF.setIsAdminLoggedIn(true);
            ProfileForm pF = mF.ShowProfileForm(1);
            bool visibility = pF.getEditButtonVisibility();
            Assert.AreEqual(true, visibility);
        }
    }
}