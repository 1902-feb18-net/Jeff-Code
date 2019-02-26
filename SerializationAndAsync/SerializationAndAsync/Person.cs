using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializationAndAsync
{
    public class Person
    {
        [XmlAttribute]
        public int Id { get; set; }

        [XmlAttribute("FullName")]
        public string Name { get; set; }

        [XmlElement(ElementName = "StreetAddress")]
        public Address Address { get; set; }

    }
}
