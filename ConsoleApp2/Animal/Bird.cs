using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Animal
{
    public  class Bird : FatherAnimal {

        Byte lengthWings = 0;
        public Bird(Byte age, String name, Byte lengthWings, String color, String sex) :base(age, name, color, sex)
        {
            this.name = name;
            this.age = age;
            this.lengthWings = lengthWings;
            this.color = color;
            this.sex = sex;
        }

        public void GetInfoBird()
        {
            GetInfo();
            Console.WriteLine($"lengthWings: {lengthWings}");
        }




        
    }
}
