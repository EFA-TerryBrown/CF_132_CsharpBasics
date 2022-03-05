using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Penny : ICurrency
{
    public string Name => "Penny";

    public decimal Value => .01m;
}

public class Dime : ICurrency
{
    public string Name => "Dime";

    public decimal Value => .10m;
}

public class Dollar : ICurrency
{
    public string Name => "Dollar";
    /*
        public string Name
        {
            return "Dollar";
        }
    */

    public decimal Value => 1.00m;
}

//change it up!!!
public class ElectronicPayment : ICurrency
{
    public string Name => "Electronic Payment";

    //b/c the value of Value can change....
    public decimal Value {get;}

    public ElectronicPayment(decimal value)
    {
        Value = value;
    }
}