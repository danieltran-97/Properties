using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1982,1,1));
            // person.Birthdate =  new DateTime(1982,1,1); This is moved to the ctor initializer
            Console.WriteLine(person.Age);
        }
    }
}
