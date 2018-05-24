using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using Store.Data;
using System.Text;
using System.Threading.Tasks;

namespace Store.Serialized
{
    class AlbumXmlSerialized
    {
        public static void Serialize(Album client, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Album));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, client);
            textWriter.Close();
        }

        public static Album Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Album));
            TextReader textReader = new StreamReader(filePath);
            Album client = (Album)deserializer.Deserialize(textReader);
            return client;
        }
    }
}
