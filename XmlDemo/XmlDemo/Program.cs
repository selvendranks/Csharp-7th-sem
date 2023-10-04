using System;
using System.Xml;
using System.Xml.Linq;

namespace XmlDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tmpxml = @"<Colleges>
                               <college id = '2116' name = 'REC'/>
                                <college id = '217' name = 'sairam'/>
                               <college id = '2566' name = 'SRM'/>
                               <college id = '2156' name = 'RamaBoy'/>
                             </Colleges>";
            XmlDocument dom = new XmlDocument();
            dom.LoadXml(tmpxml);

            XmlElement xmlelem = dom.CreateElement("college");
            XmlNode root1 = dom.DocumentElement;


            xmlelem.SetAttribute("id", "1244");
            xmlelem.SetAttribute("name", "tomBoy");
            
            root1.AppendChild(xmlelem);
            dom.Save(Console.Out);

            //update node
            int collid = 217;
            XmlNode xmlnode = dom.SelectSingleNode("Colleges/college[@id=" + collid + "]");
            xmlnode.Attributes["name"].Value = "ramagirl";
            dom.Save(Console.Out);
            
            //delete node
            int collid2 = 2566;
            XmlNode xmlnode2 = dom.SelectSingleNode("Colleges/college[@id=" + collid2 + "]");
            xmlnode2.ParentNode.RemoveChild(xmlnode2);
            dom.Save(Console.Out);

            //Select by tagname
            XmlNodeList xml = dom.GetElementsByTagName("college");
            XmlNode n3 = xml[0];
            n3.ParentNode.RemoveChild(n3);
            dom.Save(Console.Out);
            Console.ReadKey();

            //Iterate nodes
            XmlNodeList nl = dom.GetElementsByTagName("college");
            foreach(XmlNode n in nl)
            {
                var ID = n.Attributes["id"].Value;
                var Name = n.Attributes["name"].Value;

                Console.WriteLine("Name = ", Name , "Id = ", ID);
            }
            
        }
    }
}
