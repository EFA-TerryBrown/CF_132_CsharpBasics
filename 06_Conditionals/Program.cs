//Conditionals
//handle making decisions w/n an application
//called conditionals b/c they operate on specific conditions

//Anytime we want an application to work a certian way based on any condition, 
//we will use a conditional.

//Ex:
//If the user is Logged in, redirect them to the login page
//if its the users birthday, we can wish them a happy bithday
//if the user does not have the necessary role, then we can deny them access

bool isRaining = true;
bool isGoingOutside = true;

//If statements:
//formula:
//Given a boolean, if the boolean evaluates to 'true' do the action you're given

//If statemetn syntax:
//If(true/false value)
//{
    //Body of code, execute this code if above value is true  
//}

//basically:
//(isRaining == true)
if (isRaining)
{
    System.Console.WriteLine("Its raining out!");
}

//Multiple if statements
if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("Better bring an umbrella!");
}

//not raining OR not not Going outside
if(!isRaining || isGoingOutside == false)
{
    System.Console.WriteLine("I do not need an umbrella.");
}

//Exclusively not raining OR going outside
if (isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I will only go outside if it is not raining.");
}

//Challenge
//write an if statement that uses a new boolean called 'hasUmbrella' that will display text

//to the Console if the user has an umbrella and is going outside while it's raining.

//Example of expected output:
// Good thing I have my umbrella so I can go outside while it's raining!

bool hasUmbrella =true;
if (hasUmbrella && isGoingOutside)
{
    System.Console.WriteLine("Good thing I have my umbrella, so I can go outside while its raining!");
}