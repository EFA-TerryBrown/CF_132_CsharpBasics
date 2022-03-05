//Objects & OOP

//OOP -> Object oriented Programming
//Progrmming based on objects interacting w/ one another 

//Object
//basically a block of memory that as been allocated (set aside) and configured according to the
// 'blueprint'

//EVERYTHING IN C# DERIVES FROM THE OBJECT CLASS!!!!!
//Each object holds data inside of it that can be accessed
//via properties and methods.

//Ex:
//Pet object -> 'blueprint' ->overall abstraction 
//APIE
//A -> Abstraction -> Our perception of the object(blueprint) at this time.
//P -> Ploymorphism
//I -> Inheritance
//E -> Encapsulation
public class Pet
{
    //we need something to describe a pet
    public string Name {get;set;}
    public string Breed { get; set; }
    public string Color { get; set; }
    public int NumberOfLegs { get; set; }
    public int Weight { get; set; }

}

//Our end goal is to make instances of this pet object.
//Pet pet = new Pet();
//Allows us to use any of these 'properties' in our app!
// pet.Name = "Bob" ,  pet.Breed ="Bull Dog"
//used the dot operator (.) to access the needed property

