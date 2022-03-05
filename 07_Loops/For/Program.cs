using System;
//For loops

//executes a statemet or a block of code while the specified boolean expression 
//evaluates to true.
//behind the scenes a for loop is a while loop

//Syntax:
//for (initializer; condition; iterator)
// {
// body
// }

//Ex:
int number = 100;
//1    //2       //3         //4
for (int i = 0; i < number; i++)
{
    //5
    Console.WriteLine(i);
}

//1 -for keyword
//2 -Declaration of variable
//3 -Boolean expression (will run as long as the expression is true)
//4- Increment the iterator at the end of each loop
//5- body of the loop (whats performed)

//Challenge
//Promt the user for a number to count to from zero
Console.WriteLine("Give me a number (1-10)");
//Take the input from the user and store it
int userInput = Convert.ToInt32(Console.ReadLine());

// loop all numbers from zero to the number given by the user.
for (int i = 0; i < userInput; i++)
{
    //This should be inclusive (zero and the number given to you the console should appear)
    System.Console.WriteLine(i);
}

