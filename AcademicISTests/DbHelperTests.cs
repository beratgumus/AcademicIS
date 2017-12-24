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
    public class DbHelperTests
    {
        [TestMethod()]
        public void GetAcademicianTest()
        {
            Academician ac = new Academician(-1,"Ahmet",1,"Mühendislik Fakültesi",4,"Elektrik Mühendisliği",
                                              "ahmet@mail.com","5326569894","www.ahmet.com","Özgeçmiş burada :)");
            DbHelper db = new DbHelper();
            int insertedId = db.InsertAcademician(ac);
            ac.Id = insertedId;
            Academician acFromDb = db.GetAcademician(insertedId);

            Assert.AreEqual(ac.Id, acFromDb.Id);
            Assert.AreEqual(ac.Name, acFromDb.Name);
            Assert.AreEqual(ac.Phone, acFromDb.Phone);
        }
    }
}