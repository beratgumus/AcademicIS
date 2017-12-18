using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AcademicIS
{
    public static class XmlHelper
    {
        private static string Path = @"..\..\Login.xml";

        public static Boolean isAdmin(string username, string password) {

            if (!File.Exists(Path))
                return false;

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);

            foreach (XmlNode user in xmlDoc.ChildNodes[1]) {
                if (user["Name"].InnerText.Trim() == username
                    && user["Password"].InnerText.Trim() == password) {

                    return true;
                }
            }

            return false;
        }
    }
}
