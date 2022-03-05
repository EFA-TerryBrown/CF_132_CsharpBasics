using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    //Dependency Injection allows us to have loosely coupled code.
    //Dependency is something that our code requires (depends on)
    //By injecting objs from the outside, the code is easier to interact with and to test
    //This will actually give us MANY MORE OPTIONS
    //Multiple classes that implement the interface can be "swapped-out" at will 
    public interface ICurrency
    {
        //currency name
        //only use a get to keep the names from being changed in the future
        string Name {get;}

        //currency value
        decimal Value {get;}
    }
