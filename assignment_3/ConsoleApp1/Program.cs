using System;
using System.Xml;

namespace GPSLogXMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the XML file
            CreateXMLFile();

            // Read and display the XML file content
            Console.WriteLine("\nReading XML File Content:\n");
            ReadXMLFile();
        }

        static void CreateXMLFile()
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "\t"
            };

            using (XmlWriter writer = XmlWriter.Create("GPS.xml", settings))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("GPS_Log");

                writer.WriteStartElement("Position");
                writer.WriteAttributeString("DateTime", DateTime.Now.ToString());
                writer.WriteElementString("x", "65.8973342");
                writer.WriteElementString("y", "72.3452346");

                writer.WriteStartElement("SatteliteInfo");
                writer.WriteElementString("Speed", "40");
                writer.WriteElementString("NoSatt", "7");
                writer.WriteEndElement(); // End of SatteliteInfo

                writer.WriteEndElement(); // End of Position

                writer.WriteStartElement("Image");
                writer.WriteAttributeString("Resolution", "1024x800");
                writer.WriteElementString("Path", @"\images\1.jpg");
                writer.WriteEndElement(); // End of Image

                writer.WriteEndElement(); // End of GPS_Log

                writer.WriteEndDocument();
            }

            Console.WriteLine("XML File 'GPS.xml' created successfully.");
        }

        static void ReadXMLFile()
        {
            using (XmlReader reader = XmlReader.Create("GPS.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        Console.WriteLine($"Element: {reader.Name}");
                        if (reader.HasAttributes)
                        {
                            while (reader.MoveToNextAttribute())
                            {
                                Console.WriteLine($"\tAttribute: {reader.Name} = {reader.Value}");
                            }
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.Text)
                    {
                        Console.WriteLine($"\tText: {reader.Value}");
                    }
                }
            }
        }
    }
}
