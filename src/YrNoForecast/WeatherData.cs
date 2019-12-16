using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Collections;

namespace YrNoForecast
{
    [Serializable]
    [XmlRoot("weatherdata")]
    public class WeatherData
    {
        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("credit")]
        public Credit Credit { get; set; }

       // [XmlElement("links")]
        [XmlArrayItem("link")]
        public List<Link> links { get; set; }
    }
}
