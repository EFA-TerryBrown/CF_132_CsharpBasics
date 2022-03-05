using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Banana : IFruit
    {
        public Banana(){}
        public Banana(bool isPeeled)
        {
            IsPeeled=isPeeled;    
        }
        public string Name
        {
            get
            {
                return "Banana";
            }
        }

        public bool IsPeeled {get; private set;}

        public string Peel()
        {
            IsPeeled=true;
            return "You peel a Banana.";
        }
    }

public class Orange : IFruit
{
    public Orange(){}
    public Orange(bool isPeeled)
    {
        IsPeeled = isPeeled;
    }
    public string Name 
    {
        get
        {
            return "Orange";
        }
    }

    public bool IsPeeled {get;private set;}

    public string Peel()
    {
        IsPeeled=true;
        return "You peel the Orange.";
    }

    //we can also make our own unique Methods here:
    public string Squeeze()
    {
        return "You squeeze the organge and juice comes out.";
    }
}

public class Grape : IFruit
{
    public Grape(){}

    public string Name => "Grape";

    public bool IsPeeled => false;

    public string Peel()
    {
        return "Who Peels grapes?";
    }
}