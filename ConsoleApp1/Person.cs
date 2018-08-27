using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        //Fields
        public string name;
        public int age;
        public string position;
        //Constructors with 3 owerloads
        public Person() : this("J.Doul") { }//{ name = "J.Doul"; age = 16; }
        public Person(string presentName) : this(presentName,16,"FreeLanvcer") { }// { name = presentName; age = 16; position = "Freelancer"; }
        public Person(string name, int age) { name = this.name;age = this.age; position = "Develkoper"; }
        public Person(string presentName, int presentAge, string presentPosition) { name = presentName; age = presentAge; position = presentPosition; }
        //methods
        public void SayHello()
        {
            Console.WriteLine("Hello!\n my name is {0}\n I'm {1} years old\n I'm work as {2}\n ================================",name,age,position);
        }

    }
}
