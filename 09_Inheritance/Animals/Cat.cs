using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09_Inheritance.Animals
{
    public class Cat : Animal
    {
        public Cat()
        {
            System.Console.WriteLine("This is the Cat Constructor.");
            IsMamal=true;
            DietType= DietType.Carnivore;
        }

        //we can make our own properties for 'Cat' as well
        public double ClawLength { get; set; }

        //make our own virtual Method
        public virtual void MakeSound()
        {
            System.Console.WriteLine("Meow.");
        }

        //override the Move() (its on the Animal Class)
        public override void Move()
        {
            System.Console.WriteLine($"The {GetType().Name} moves quickly!");
        }
    }

    public class TabbyCat : Cat
    {
        public TabbyCat()
        {
         System.Console.WriteLine("This is the Tabby Cat Constructor!");   
        }
        public override void MakeSound()
        {
            System.Console.WriteLine("Purr....");
        }
    }

    public class Liger : Cat
    {
        public Liger()
        {
            System.Console.WriteLine("This is the Liger constructor.");
        }

        //give the Liger a different way to move
        public override void Move()
        {
            System.Console.WriteLine($"The {GetType().Name} stalks its prey.");
            base.Move();//this is the functionality from the base class.
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("ROAR!");
        }
    }
}