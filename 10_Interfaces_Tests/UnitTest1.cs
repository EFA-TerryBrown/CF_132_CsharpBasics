using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void CallingInterfaceMethods()
    {
        //declare a new interface instance
        //we will declare this as an IFruit
        //cannot create an 'new' IFruit , but
        // we can make a new Banana() b/c 
        //it implements IFruit....
        IFruit banana = new Banana();
        
       var output = banana.Peel();
       System.Console.WriteLine(output);

       System.Console.WriteLine("The bananna is Peeled:" + banana.IsPeeled);
       Assert.IsTrue(banana.IsPeeled);

    }

    [TestMethod]
    public void InterfacesInCollections()
    {
        //well start w/ an orange object
        //this time we want it as an orange not an IFruit!
        var orange = new Orange();

        //we'll make a list
        //ctrl + (.) using System.Collections.Generic
        List<IFruit> fruits = new List<IFruit>
        {
            new Banana(),
            new Grape(),
            orange
        };

        //loop through all of the fruits
        foreach(var fruit in fruits)
        {
            System.Console.WriteLine(fruit.Name);
            System.Console.WriteLine(fruit.Peel());

            //lets make an assertion based on the IFruit Type
            Assert.IsInstanceOfType(fruit,typeof(IFruit));
        }
        
        System.Console.WriteLine(orange.Squeeze());

        Assert.IsInstanceOfType(orange,typeof(Orange));

    }

    private string GetFruitName(IFruit fruit)
    {
        return $"This fruit is called {fruit}.";
    }

    [TestMethod]
    public void InterfacesInMethods()
    {
        var grape = new Grape();

        //this works b/c grape implements IFruit
        var output = GetFruitName(grape);

        System.Console.WriteLine(output);

        Assert.IsTrue(output.Contains("This fruit is called Grape."));
    }

    [TestMethod]
    public void TypeOfInstance()
    {
        var fruitSalad = new List<IFruit>
        {
            new Orange(true),
            new Orange(),
            new Grape(),
            new Orange(),
            new Banana(true),
            new Grape()
        };

        System.Console.WriteLine("Is the orange Peeled?");
        foreach(var fruit in fruitSalad)
        {
            //This allows us to use casting
            //we are checking to see if a fruit is a certian type..
            //lower cased orange is the new temp variable...
            if(fruit is Orange orange)
            {
                if(orange.IsPeeled)
                {
                    System.Console.WriteLine("Is a peeled Orange.");
                }
                else
                {
                    System.Console.WriteLine("Is an Orange.");
                }
            }
            else if(fruit.GetType()==typeof(Grape))
            {
                System.Console.WriteLine("Is a Grape.");

            }
            else if(fruit.IsPeeled)
            {
                System.Console.WriteLine("You peeled a banana.");
            }
            else
            {
                System.Console.WriteLine("Is a Banana.");
            }
        }
    }

}


// Pattern Matching
    // Another way to demonstrate checking types is with Pattern Matching
    // Docs: https://docs.microsoft.com/en-us/dotnet/csharp/pattern-matching
    // This is basically the same way we did the first if (fruit is Orange orange)