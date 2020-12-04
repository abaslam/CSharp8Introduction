using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8Introduction.Lessons
{
    public class NullableReferenceTypes
    {
        public static void Run()
        {
            Person? person = null;
            if (person != null)
            {
                person.FirstName = "What";
            }

            person.FirstName = "testc";

            
            //Person newPerson = null;

            

            Person anotherPerson = new Person();
            anotherPerson.FirstName = "Another";
        }
    }

    public class Person
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
    }
}
