using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Store.Data
{
    [Table("Games")]
    public class Game
    {
        int gameId = 0;
        string gameName = "";
        float price = 0.0f;
        string genre = "";
        DateTime date = DateTime.Today;
        string publisher = "";
        float grade = 0.0f;
        string description = "";
        
        [XmlElement("Game-name")]
        public string GameName
        {
            get { return gameName; }
            set { gameName = value; }
        }
        [XmlElement("Price")]
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        [XmlElement("Genre")]
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        [XmlElement("Date")]
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        [XmlElement("Publisher")]
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        [XmlElement("Grade")]
        public float Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        [XmlElement("Description")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [Key]
        public int GameId
        {
            get { return gameId; }
            set { gameId = value; }
        }

    }
}
