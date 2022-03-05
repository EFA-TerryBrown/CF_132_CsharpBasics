using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Dragon : Animal
    {
        public Dragon()
        {
            HasFur=false;
            IsMamal=false;
            DietType=DietType.Carnivore;
        }
    }

    public class Wyrm: Dragon
    {
        public Wyrm()
        {
            NumberOfLegs=0;
        }
    }

    public class Hydra:Dragon
    {
        public int HeadCount { get; set; } =5;
    }
