using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CryptoProject
{
    class XMLOperations
    {
        public XmlDocument ImportXML(String path) {
            Console.WriteLine(path);

            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            Console.WriteLine(doc.ToString());
            return doc;
        }

        
        public String[] GetRSAValues(XmlDocument doc)
        {
            Console.WriteLine(doc.DocumentElement.OuterXml);
            String privatePath = "ALGORITMO/clavePrivada";
            String publicPath = "ALGORITMO/clave";
            XmlNode nodesPrivate = doc.SelectSingleNode(privatePath);
            XmlNode nodesPublic = doc.SelectSingleNode(publicPath);
            /*Console.WriteLine(nodes.InnerText);*/
            /*2 ES PUBLICO*/
            XmlDocument newDoc = new XmlDocument();
            newDoc.LoadXml(nodesPrivate.InnerText);
            XmlDocument newDoc2 = new XmlDocument();
            newDoc2.LoadXml(nodesPublic.InnerText);

            String keysPath = "ALGORITMOKeyValue";
            XmlNodeList keysnodes = newDoc.SelectNodes(keysPath);
            XmlNode nodePrivate = newDoc.SelectSingleNode("ALGORITMOKeyValue");
            XmlNode nodePublic = newDoc2.SelectSingleNode("ALGORITMOKeyValue/Modulus");
            Console.WriteLine(nodePublic.InnerText);
            Console.WriteLine(nodePrivate.InnerText);

            String[] data = { nodePublic.InnerText, nodePrivate.InnerText, nodesPrivate.InnerText };
            return data;
        }
        
    }
}
