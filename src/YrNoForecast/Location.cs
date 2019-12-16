using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
namespace YrNoForecast
{
    [Serializable]
   public class Location
    {
        
        /// <summary>
        /// City Name
        /// </summary>
        [XmlElement("name")]
        public String Name { get; set; }

        /// <summary>
        /// Type of the city
        /// </summary>
        [XmlElement("type")]
        public String Type { get; set; }

        /// <summary>
        /// Country Name
        /// </summary>
        [XmlElement("country")]
        public String Country { get; set; }

        /// <summary>
        /// City timezone
        /// </summary>
        [XmlElement("timezone")]
        public TimeZone TimeZone { get; set; }

        /// <summary>
        /// City location with geografical coordinates
        /// </summary>
        [XmlElement("location")]
        public GeoLocation GeoLocation { get; set; }

    }
}
