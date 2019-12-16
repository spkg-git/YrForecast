using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    [Serializable]
    public class GeoLocation
    {
        /// <summary>
        /// Altitude оf city in meters
        /// </summary>
        [XmlAttribute("altitude")]
        public Int16 Altitude { get; set; }

        /// <summary>
        /// Latitude of city in meters
        /// </summary>
        [XmlAttribute("latitude")]
        public Double Latitude { get; set; }

        /// <summary>
        /// Longitude of city in meters
        /// </summary>
        [XmlAttribute("longitude")]
        public Double Longitude { get; set; }

        /// <summary>
        /// Geobase using
        /// </summary>
        [XmlAttribute("geobase")]
        public String Geobase { get; set; }

        /// <summary>
        /// Geobase ID
        /// </summary>
        [XmlAttribute("geobaseid")]
        public UInt32 Geobaseid { get; set; }
    }
}