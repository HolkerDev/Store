﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Store.Data
{
    public class Album
    {
        string albumName = "";
        float price = 0.0f;
        string genre = "";
        DateTime date = DateTime.Today;
        string author = "";
        float grade = 0.0f;
        string description = "";

        [XmlElement("Album-name")]
        public string AlbumName
        {
            get { return albumName; }
            set { albumName = value; }
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
        [XmlElement("Author")]
        public string Author
        {
            get { return author; }
            set { author = value; }
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

        public int AlbumId
        {
            get;
            set;
        }
    }
}
