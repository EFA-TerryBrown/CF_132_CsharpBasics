using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public abstract class Animal
    {
        public Animal()
        {
            System.Console.WriteLine("This is the Animal Constructor.");
        }

        //define the attributes of 'Animal'
        public int NumberOfLegs { get; set; }
        public bool IsMamal { get; set; }
        public bool HasFur { get; set; }
        public DietType DietType { get; set; }

        //virtual keyword allows any inheriting class
        //to 'overwrite' this method if needed to perform other actions.
        //(you can make animal move differently (if you want....))
        public virtual void Move()
        {
            System.Console.WriteLine($"This {GetType().Name} moves.");
        }
        
    }
