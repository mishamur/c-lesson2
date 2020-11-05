using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animal
{
    public abstract class FatherAnimal
    {
        protected String sex = "none";
        protected Byte age = 0;
        protected String name = "none";
        protected String color = "none";
        public FatherAnimal(Byte age, String name, String color, String sex)
        {
            this.color = color;
            this.sex = sex;
            this.age = age;
            this.name = name;
        }

        

        public String getName()
        {
            return this.name;
        }

        public Byte getAge()
        {
            return this.age;
        }

        protected virtual void GetInfo()
        {
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"color: {color}");
            Console.WriteLine($"sex: {sex}");

        }
    }
}
