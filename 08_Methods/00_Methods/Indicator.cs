using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Indicator
    {
        public bool IsFlashing {get; private set;}

        public void TurnOn()
        {
            IsFlashing=true;
        }

        public void TurnOff()
        {
            IsFlashing=false;
        }
    }
