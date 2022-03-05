//Properties:

//Defining Properties
//properties give you the ability to read or write to a specific piece of data (or private field)

//They are members that live inside of an object
// read / write/ compute

//public '{get;set;}' 

//properties enable data to be accessed easily and promotes safety w/n the application

Donut doug = new Donut();
doug.Filling="Strawberry Jam";

System.Console.WriteLine(doug.GetDonutType());

//testing other properties
doug.Topping="Sprinkles";
doug.IsSpecial=false;
doug.Price=1.98m;

System.Console.WriteLine(doug.DountDetails());

System.Console.WriteLine("-------------Special Donut---------------------");

Donut doug2 = new Donut("Special Type","Blueberry","none",true);
System.Console.WriteLine(doug2.DountDetails());

class Donut
{
    //private backing field
    private string dounutType;

    //pubic property (everyone can use...)
    public string  Filling { get; set; }

    public string Topping { get; set; }
    public decimal Price {get;set;} =.25m;
    public bool IsSpecial {get;set;}= false;

    //Constructors
    public Donut(string type)
    {
        dounutType=type;
    }
    public Donut(string type, string filling, string topping,bool isSpecial)
    {
        dounutType=type;
        Filling=filling;
        Topping=topping;
        IsSpecial=isSpecial;
        CalculateSpecialPrice(IsSpecial);
    }
    public Donut()
    {
        
    }

    public string GetDonutType()
    {
        return dounutType;
    }

    public void SetDonutType(string type)
    {
        dounutType = type;
    }

    public void CalculateSpecialPrice(bool isSpecial)
    {
        if(IsSpecial)
        {
            Price*=2;
        }
    }

    public string DountDetails()
    {
       return $"This dounut is {this.GetDonutType()}\n full of {this.Filling}\n and topped with {this.Topping}\n for ${this.Price}";
    }
}