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

        public static Boolean isAdmin(string username,string password)
        {
           
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Path);

                XmlNode loginNode = xmlDoc.ChildNodes[0];

                if(loginNode["username"].InnerText.Trim() == username
                   && loginNode["password"].InnerText.Trim() == password)
                {
                    return true;
                }
        
            return false;
        }


        
    }
}
