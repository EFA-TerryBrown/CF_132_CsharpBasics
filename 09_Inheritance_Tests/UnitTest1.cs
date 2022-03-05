using Microsoft.VisualStudio.TestTools.UnitTesting;
using _09_Inheritance.Animals;
using System.Collections.Generic;

namespace _09_Inheritance_Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Create_A_Cat_Should_ShowAll_Info()
    {
        Cat CatA = new Cat();
        CatA.ClawLength =44.25d;
        
        double clawLength=CatA.ClawLength;

        CatA.MakeSound();
        CatA.Move();
        Assert.AreEqual(clawLength,44.25d);
    }

    [TestMethod]
    public void Create_A_TabbyCat()
    {
        TabbyCat tCat = new TabbyCat();
        tCat.NumberOfLegs=3;
        tCat.ClawLength=2.2d;
        tCat.Move();
        tCat.MakeSound();
        Assert.AreEqual(tCat.GetType(),typeof(TabbyCat));
    }

    public string DisplayAnimalType(Animal animal)
    {
        return $"{animal.GetType().Name}";
    }

    [TestMethod]
    public void I_Am_An_Animal()
    {
        Cat catA = new Cat();
        Liger ligerA = new Liger();
        Dragon dragonA = new Dragon();

        List<Animal> animals = new List<Animal>
        { 
            catA,
            ligerA,
            dragonA
        };

        foreach(Animal animal in animals)
        {
           System.Console.WriteLine($"This is a {DisplayAnimalType(animal)}");
        }

    }
    
}