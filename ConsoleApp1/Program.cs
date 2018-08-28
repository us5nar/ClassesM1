using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person joe = new Person();
            Person vasilij = new Person("Вася");
            Person james = new Person("James Bond", 33);
            //Person adult = new Person("Big Guy", 39, "spy");
            //it is an example of private constructor as a base
            Person tom = new Person { name = "Tom", age = 31, position = "Chupacabra" };//init of an object - overridding all constructors

            joe.SayHello();
            vasilij.SayHello();
            james.SayHello();
            //adult.SayHello();
            tom.SayHello();

            Console.ReadLine();
        }
    }
}
