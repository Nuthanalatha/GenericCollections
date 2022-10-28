using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class AnonymousType
    {
        public void Nested()
        {
            // Creating and initializing nested anonymous object
            var anony_object = new
            {
                s_id = 149,
                s_name = "Soniya",
                language = "C#",
                anony_ob = new { email = "soniya45@gmail.com" }
            };

            // Accessing the object properties
            Console.WriteLine("Student id: " + anony_object.s_id);
            Console.WriteLine("Student name: " + anony_object.s_name);
            Console.WriteLine("Language: " + anony_object.language);
            Console.WriteLine("Email: " + anony_object.anony_ob.email);
        }
    }
}
