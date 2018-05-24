using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Store.Data;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Store.Serialized
{
    class MovieXmlSerialized
    {
        public static void Serialize(Movie client, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Movie));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, client);
            textWriter.Close();
        }

        public static Movie Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Movie));
            TextReader textReader = new StreamReader(filePath);
            Movie client = (Movie)deserializer.Deserialize(textReader);
            return client;
        }
    }
}
