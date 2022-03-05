//Constructors

//So what if we want to create our object and assign properties 'on the fly'

//This is where constructors come in!

//Its one of the first pieces of code that is run when and object is 'constructed' (new keyword)

//Syntax for a constructor

//1. Access Modifier
//2. name of the type, in our case its Donut
//3. A pair of parenthesis containing any parameters
//4. The body containing any code that needs to execute.

using Classes;

Donut doug = new Donut("Jelly Filled");
System.Console.WriteLine(doug);
System.Console.WriteLine(doug.donutType);

Donut doug2 = new Donut();
doug2.donutType="Creme Filled";
System.Console.WriteLine(doug2.donutType);

namespace Classes
{
    class Donut
    {
        public string? donutType;

        //This is the constructor
        //1     //2    //3
        public Donut(string type)
        {
            //4
            donutType=type;
        }
        //This is our defalut empty constructor
        //we have to make this if we make our own type of constructor
        //that takes in any parameters
        public Donut()
        {
            
        }
    }
}