using System;
using System.Collections.Generic;
using System.Linq;
using Store.Data;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Threading.Tasks;

namespace Store.Serialized
{
    class GameXmlSerialized
    {
        public static void Serialize(Game client, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Game));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, client);
            textWriter.Close();
        }

        public static Game Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Game));
            TextReader textReader = new StreamReader(filePath);
            Game client = (Game)deserializer.Deserialize(textReader);
            return client;
        }
    }
}
