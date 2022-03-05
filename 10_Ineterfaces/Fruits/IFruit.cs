using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    //Always start with the letter I , then the rest of the word
    //EVERYTHING THATS AN INTERFACE IS ALWAYS PUBLIC 
    public interface IFruit
    {
        string Name{get;}  //property only w/ get
        bool IsPeeled{get;} //property with get, but will be set w/n the class
        string Peel();  //Method w/ a return type
    }
