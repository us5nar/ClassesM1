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
        private string _name;
        private int _age;
        private string _position;

        //Constructors with 3 owerloads
        public Person() : this("J.Doul") { }//{ name = "J.Doul"; age = 16; }

        public Person(string name) : this(name, 16, "FreeLanvcer") { }// { name = presentName; age = 16; position = "Freelancer"; }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            _position = "Developer";
        } //Why doesn't work? (for James)

        //private (base) constructor - questions: factory and singltone
        private Person(string name, int age, string position)
        {
            _name = name;
            _age = age;
            _position = position;
        }
        //methods
        public void SayHello()
        {
            Console.WriteLine("Hello!\n my name is {0}\n I'm {1} years old\n I'm work as {2}\n ================================", _name, _age, _position);
        }

    }
}
