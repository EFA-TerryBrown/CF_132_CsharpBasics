//So when make an If statement, what happens when conditions aren't met
//This is where we use the else keyword (default "if all else fails")

//Example w/o the else statement
bool isRaining = true;

//Check if the inverse if isRaining is true
if (!isRaining)
{
    System.Console.WriteLine("I'll go cut the grass.");
}
//Check if isRaining is true
if (isRaining)
{
    System.Console.WriteLine("I guess I can't cut the grass!");
}

//Ex: (w/ else statement):
if (!isRaining)
{
    System.Console.WriteLine("I will go cut the grass.");
}
else
{
    System.Console.WriteLine("I guess I can't go cut the grass.");
}

//Another exmple:
bool isGoingOutside = true;

if (isGoingOutside)
{
    System.Console.WriteLine("Make sure to dress for the weather!");
}
else
{
    System.Console.WriteLine("Sounds like a sweates kind of day.");
}

//Another example:
if (isGoingOutside)
{
    System.Console.WriteLine("Make sure to dress for the weather!");
}
else if (isGoingOutside && isRaining)
{
    //code goes here....
}
else if (isRaining)
{
    //code goes here....
}
else
{
    System.Console.WriteLine("Sounds like a sweates kind of day.");
}

//Another example:
if (isGoingOutside)
{
    if (isRaining)
    {

    }
}

// if(isGoingOutside && isRaining) the same as above...

//Challenge
//If..Else If Statements
//We are going to ask the user how they are doing on a scale of 1-5, with 5 being the best.
System.Console.WriteLine("How are you doing? (1-5)");

//this changes the 'string' value to and interger
string value = Console.ReadLine();
// int value = int.Parse(Console.ReadLine());

//We will run the nested if..else statements based on ther input with these responses:
if (value == "1")
{
    //1. Dang. We hope your day gets better!
    System.Console.WriteLine("Dang. We hope your day gets better!");
}
else if (value == "2")
{
    //2. Oh. Sorry to hear that.
    System.Console.WriteLine("Oh. Sorry to hear that.");
}
else if (value == "3")
{
    //3. Hope things improve!
    System.Console.WriteLine("Hope things improve!");
}
else if (value == "4")
{
    //4. Good stuff!
    System.Console.WriteLine("Good stuff!");
}
else if (value == "5")
{
    //5. That's great to hear!
    System.Console.WriteLine("That's great to hear!");
}
else
{
    System.Console.WriteLine("Invalid key entry.");
}
