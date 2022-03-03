//Ternary Expressions
//conditional operator
//Its composed of three parts

//The syntax looks like this:
        //1         //2                  //3
//boolean expression ? expression if true : expression if false;

//3parts 
//1. boolean expression to be evaluated
//2. seperates the boolean and the true result
//3. seperates the true and false results

//Ex:
System.Console.WriteLine("Enter your age: ");
string response = Console.ReadLine();
int age = int.Parse(response);

//output:
string output = (age >= 18) ? "You can vote!" : "You're too young to vote.";


Console.WriteLine(output);