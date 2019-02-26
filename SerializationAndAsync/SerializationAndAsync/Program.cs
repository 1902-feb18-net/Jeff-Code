using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace SerializationAndAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    Name = "Nick",
                    Address = new Address
                    {
                        Street = "123 Main St",
                        City = "Fort Worth",
                        State = "TX"
                    }
                },
                 new Person
                {
                     Id = 2,
                     Name = "Fred",
                    Address = new Address
                    {
                        Street = "123 Main St",
                        City = "Reston",
                        State = "VA"
                    }
                 }
            };

            string newline = "\n";

            string fileName = @"C:\revature\persons_data.xm;";

            SerializeAsXMLToFile(fileName, persons);

        }
            private static void SerializeAsXMLToFile(string fileName, List<Person> persons)
            {
                var serializer = new XmlSerializer(typeof(List<Person>));
            }
    }
}
