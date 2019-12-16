using System;
using System.Xml.Serialization;
namespace YrNoForecast
{
    [Serializable]

    /// <summary>
    /// Link to web page of city 
    /// </summary>
   
    public class Link
    {
        /// <summary>
        /// Link Type
        /// </summary>
        [XmlAttribute("id")]
        public String Id { get; set; }

        /// <summary>
        /// Link to web page of city 
        /// </summary>
        [XmlAttribute("url")]
        public String Url { get; set; }
    }
}