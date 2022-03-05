using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Sloth : Animal
    {
        public Sloth()
        {
            System.Console.WriteLine("Sloth Constructor.");
        }

        //we are going to make this property READ-ONLY
        public bool IsSlow
        {
            //totally omitting the setter, b/c we don't need it
            //in our app the sloth is "Always slow"
            get
            {
                return true;
            }
        }

        public override void Move()
        {
            System.Console.WriteLine("The Solth moves Slowly!");
        }
    }

    public class Megatherium : Sloth
    {
        public Megatherium()
        {
            System.Console.WriteLine("This sloth is extinct.");
        }
        public override void Move()
        {
            System.Console.WriteLine("Megatherium uses Move! It's not super effective....");
        }
    }
