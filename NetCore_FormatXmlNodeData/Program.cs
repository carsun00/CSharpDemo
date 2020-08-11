using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace XmlNodeFormat
{
    class Program
    {
        
        static void Main(string[] args)
        {
            XDocumentToList_Linq Demo = new XDocumentToList_Linq();

            Demo.ReadXmlReturnList();
            Console.WriteLine(Demo.ReadXmlReturnList());
        }

       
    }
}
