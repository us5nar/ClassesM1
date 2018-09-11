using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 5;
            string name = "Bob";
            DemonstrateNamedAndDefaultArguments(fullName: name, ageOfStudent: age);
            DemonstrateNamedAndDefaultArguments(age);
            DemonstrateNamedAndDefaultArguments(fullName: name);
            DemonstrateNamedAndDefaultArguments();

            int i = 5;

            Increment(i);


            Console.WriteLine(i);

            Increment(ref i);
            Console.WriteLine(i);

            Student student = new Student { Age = 19 };

            IncreaseAgeOfStudent(student);
            Console.WriteLine(student.Age);

            IncreaseAgeOfStudent(ref student);
            Console.WriteLine(student.Age);

            Console.ReadKey();
        }

        public static void DemonstrateNamedAndDefaultArguments(int ageOfStudent = 20, string fullName = "Ivan")
        {
            Console.WriteLine($"{ageOfStudent} {fullName}");
        }


        public static void Increment(int integer)
        {
            integer++;
        }

        public static void Increment(ref int integer)
        {
            integer++;
        }

        public static void IncreaseAgeOfStudent(Student student)
        {
            student = new Student() { Age = 100};
        }

        public static void IncreaseAgeOfStudent(ref Student student)
        {
            student = new Student() { Age = 100 };
        }
    }

    class Student
    {
        public int Age { get; set; }
    }
}


