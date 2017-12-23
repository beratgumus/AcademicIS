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
    public class CourseScheduleFormTests
    {
        [TestMethod()]
        public void GetAcademicianIdTest()
        {
            int expectedId =1 ;
            CourseScheduleForm CSF = new CourseScheduleForm(expectedId, false);
            int actualId = CSF.GetAcademicianId();
            Assert.AreEqual(expectedId, actualId);
            bool editVisibility = CSF.GetEditButtonVisibility();
            bool deleteVisibility = CSF.GetDeleteButtonVisibility();
            Assert.AreEqual(false, editVisibility);
            Assert.AreEqual(false, deleteVisibility);
        }
    }
}