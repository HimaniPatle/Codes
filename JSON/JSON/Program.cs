/*JSON : (JavaScript Object Notation) is an open-standards document format for human readable and machine understandable
serialization and deserialiation of data.Simply, it is usedfor data interchange.*/
//JSON is a text format that is completely language independent. 
//Serialization in .NET :Serialization is the process of converting .NET objects such as strings into a JSON format.
//Deserialization is the process of converting JSON data into .NET objects.

//DataContractJsonSerializer class helps to serialize and deserialize JSON.
//It is present in namespace System.Runtime.Serialization.Json
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace JSON
{
    class Program
    {
        [DataContract]  //Define the data contract for Person by attaching the DataContractAttribute to the class and
                        //DataMemberAttribute attribute to the members you want to serialize.
        internal class Person
        {
            [DataMember]
            internal string Name { get; set; }

            [DataMember]
            internal int Age{ get; set; }
        }
        static void Main(string[] args)
        {
            var p = new Person();//Create an instance of the Person type.
            p.Name = "Himani";
            p.Age = 22;

            var stream1 = new MemoryStream();//Serialize the Person object to a memory stream by using the DataContractJsonSerializer.
            var s = new DataContractJsonSerializer(typeof(Person));
            s.WriteObject(stream1, p);//Use the WriteObject method to write JSON data to the stream.

            //Showing the JSON output.
            stream1.Position = 0;
            var sr = new StreamReader(stream1);
            Console.Write("JSON format created for the Person object : ");
            Console.WriteLine(sr.ReadToEnd());
            Console.WriteLine("\n");

            //Deserialize the JSON-encoded data into a new instance of Person
            //by using the ReadObject method of the DataContractJsonSerializer.
            stream1.Position = 0;
            var p2 = (Person)s.ReadObject(stream1);
            Console.WriteLine($"Deserialized back, got name = {p2.Name}, age = {p2.Age}");
            Console.ReadLine();


        }
    }
}
