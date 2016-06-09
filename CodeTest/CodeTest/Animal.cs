using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    class Animal
    {
        protected String name = "";

        protected Animal(String Animalname)
        {
            name = Animalname;
        }



        protected String Name
        {
            get; set;
        }

        protected void Speak()
        {
            Console.WriteLine("Animal: " + name + " spoke.");
        }
    }


    class Dog : Animal{
            
        public Dog(String n) : base(n)
        {
            this.Name = n;
        }

        public void Speak()
        {
            Console.WriteLine("Dog: " + name + " barked.");
        }
    }

    class Cat : Animal
    {

        public Cat(String n) : base(n)
        {
            this.Name = n;
        }

        public void Speak()
        {
            Console.WriteLine("Cat: " + name + " meowed.");
        }
    }
}
