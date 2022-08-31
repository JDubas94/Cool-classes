using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cool_classes
{
    class Person
    {
        private string _name;
        private string _age;
        public Person(string name, string age)
        {
            _name = name;
            _age = age;

        }

        public void GetInfo()
        {
             Console.WriteLine(_name + " age is " + _age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");

            var name1 = Console.ReadLine();

            Console.WriteLine("Enter your age: ");

            var age1 = Console.ReadLine();

            Person person = new Person(name1, age1);

            person.GetInfo();

            var age2 = 2;

            Console.WriteLine(age2);


            Console.ReadLine();

        }
    }
}
