using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Vehicle
    {
        // public Vehicle()
        // {
        //     Indicator RightIndicator= new Indicator();
        //     Indicator LeftIndicator= new Indicator();
        // }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public double Milage { get; set; }
        public VehicleType VehicleType {get;set;}

        //this IsRunning property can only be 'changed' w/ a Method
        //that live inside of this class.
        public bool IsRunning { get; private set; }

        public Indicator RightIndicator { get; set; } =new Indicator();
        public Indicator LeftIndicator { get; set; } = new Indicator();

        //1st Method:
        public void TurnOn()
        {
            IsRunning=true;

            System.Console.WriteLine("The vehicle is TURNED ON!");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("The vehicle is TURNED OFF!");
            IsRunning=false;
        }

        public void IndicateRight()
        {
            RightIndicator.TurnOn();
            LeftIndicator.TurnOff();
        }

        public void IndicateLeft()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOff();
        }

        public void TurnOnHazzards()
        {
            LeftIndicator.TurnOn();
            RightIndicator.TurnOn();
        }

        public void ClearIndicators()
        {
            LeftIndicator.TurnOff();
            RightIndicator.TurnOff();
        }

    }
