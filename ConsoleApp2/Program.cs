using System;
using ConsoleApp2.Animal;


//2 урок!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!11---------------------------------------------------------------
//задание, множество животных разных типов, птица, млекопитающее, земноводное
//
namespace ConsoleApp2
{
    class Student
    {
        string name;
        Byte age;
        public Student(string name, Byte age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetAge()
        {
            return this.age;
        }

        public void SetAge(byte age)
        {
            this.age = age;
        }
    }













    internal class Program
    {
        static void Main(string[] args)
        {
            Fish a = new Fish(12, "Selachii", "Gray", "male","Hryashevie");
            a.GetInfoFish();
            Console.WriteLine();

            Bird b = new Bird(5, "sini4ka", 7, "multiColor", "female");
            b.GetInfoBird();
            Console.WriteLine();
            Console.WriteLine();


            Mammals c = new Mammals(5, "Leon", "Orange", "Male", false);
            c.GetInfoMammals();
            Console.WriteLine();


        }
    }
}
