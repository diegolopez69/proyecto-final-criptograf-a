using System;
using System.Xml;

namespace CryptoProject
{
    class XMLOperations
    {
        public XmlDocument ImportXML(String ruta)
        {
            Console.WriteLine(ruta);
            XmlDocument documentoXML = new XmlDocument();
            documentoXML.Load(ruta);
            Console.WriteLine(documentoXML.ToString());
            return documentoXML;
        }

        public String[] GetRSAValues(XmlDocument documentoXML)
        {
            String RutaDeLaLlavePrivada = "ALGORITMO/clavePrivada";
            String RutaDeLaLlavePublica = "ALGORITMO/clave";
            XmlNode NodoDeLaLlavePrivada = documentoXML.SelectSingleNode(RutaDeLaLlavePrivada);
            XmlNode NodoDeLaLlavePublica = documentoXML.SelectSingleNode(RutaDeLaLlavePublica);
            XmlDocument documentoDeLlavePrivada = new XmlDocument();
            documentoDeLlavePrivada.LoadXml(NodoDeLaLlavePrivada.InnerText);
            XmlDocument documentoDeLlavePublica = new XmlDocument();
            documentoDeLlavePublica.LoadXml(NodoDeLaLlavePublica.InnerText);

            String RutaDeLaLlave = "ALGORITMOKeyValue";
            XmlNodeList keysnodes = documentoDeLlavePrivada.SelectNodes(RutaDeLaLlave);
            XmlNode NodoPrivado = documentoDeLlavePrivada.SelectSingleNode("ALGORITMOKeyValue");
            XmlNode NodoPublico = documentoDeLlavePublica.SelectSingleNode("ALGORITMOKeyValue/Modulus");
            Console.WriteLine(NodoPublico.InnerText);
            Console.WriteLine(NodoPrivado.InnerText);

            String[] data = { NodoPublico.InnerText, NodoPrivado.InnerText, NodoDeLaLlavePrivada.InnerText };
            return data;
        }

    }
}
