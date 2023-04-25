using System.Xml;
using ExerciceXmlWriter;

var parametres = new XmlWriterSettings
{
    Indent = true
};
var writer = XmlWriter.Create("fichier.xml", parametres);

writer.WriteStartElement("Personne");

    writer.WriteElementString("Nom", "MOMMER");
    writer.WriteElementString("Nom", "Christophe");

    writer.WriteStartElement("DateDeNaissance");
        writer.WriteValue("1988-12-18T00:00:00");
    writer.WriteEndElement();

    writer.WriteStartElement("Taille");
        writer.WriteValue("181");
    writer.WriteEndElement();

writer.WriteEndElement();

writer.Flush();
