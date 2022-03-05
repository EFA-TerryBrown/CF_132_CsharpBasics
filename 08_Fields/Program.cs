//Fields

//A Field is a variable of any type that is declared directly inside a type.
//Also a 'member' of the class

//A field contains:
//An access Modifier -> defines what 'pieces' of code can use it
// public -> everyone has access 
// private -> only the containing class has access
// protected -> only inheriting class has access
// internal  -> only the assembly has access

//use using statement
using Classes;

Donut doug = new Donut();
System.Console.WriteLine(doug);

System.Console.WriteLine("----");

doug.donutType= "Jelly Filled";
System.Console.WriteLine(doug.donutType);

namespace Classes
{
    class Donut
    {
        //This is a string and its publicly accessible
               //type   //name
        public string? donutType;
    }
}