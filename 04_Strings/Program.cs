//Strings

//Just a collection of characters stored and used throughout an application in different ways
//Almost any text, single character, or number can be a string

//In C# we can initialize string by using double quotes ("") wrapped around the value

//3 ways to use a string type
//Concatenation
//Composite Formatting
//Interpolation

//Concatenation Ex:
string first = "The cars we sell are";
string second = "BMW, Lexus, and Mercedes.";

string concatenatedResult = first + " " + second;
//basically taking the variables and (+) them one to another
//we also added the " " as well.
System.Console.WriteLine(concatenatedResult);

//Composite Formatting
//using {} braces inside of the string itself with a number inside of the braces
string firstName = "Jenn";
string lastName = "Williams";

//now we need to use string.Format method
string compositeResult = string.Format("Her name is {0} {1}",firstName,lastName);
System.Console.WriteLine(compositeResult);

//String Interpolation
//Allows you to simply put a variable directly into the string.
string interpolationResult = $"Her name is still {firstName} {lastName}.";
System.Console.WriteLine(interpolationResult);

//Challenge
//Practice these three ways of joining strings (3) more examples of each