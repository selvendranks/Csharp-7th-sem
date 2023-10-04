using System;
using System.Xml;

class Program
{
    static void Main()
    {
        string xmlContent = @"<colleges>
<college id='2116' name='REC' />
<college id='2117' name='RIT' />
<college id='2118' name='RSA' />
<college id='2119' name='RGCE' />            
</colleges>";

        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlContent);

        XmlNode college = doc.SelectSingleNode("//college[@id='2116']");
        if (college != null)
        {
            college.Attributes["name"].Value = "RU";
        }

        Console.WriteLine(doc.OuterXml);
        Console.ReadKey();
    }
}
