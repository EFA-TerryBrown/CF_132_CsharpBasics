//Syntax
//value being evaluated, often a variable
// The switch keyword
//A body that contains 'cases', called "expression arms", denoted by curly braces {}
//The comma seperated by 'expression arms' are made up of 3 parts:
    //1. The expected value, called a "pattern"
    //2. A "Fat Arrow", denoted as '=>'
    //3. The actual expression or value to be returned
//A discard pattern, denoted with an "_", which is the default

System.Console.WriteLine("Please enter a userName: ");
//-Switch expressions
string userName = Console.ReadLine();
string greeting = userName switch
{
    "Pete"=>"Hello Pete",// value thats returned if the variable userName has a value of "Pete"
    _ =>"Who are you?" //Return value for every other possible value for name
};

System.Console.WriteLine(greeting);

//real Example:
System.Console.WriteLine("How are you feeling today? (1-5)");
string feelingRating = Console.ReadLine();

switch (feelingRating)
{
    case "5":
        System.Console.WriteLine("That's great to hear!");
        break;

    case "4":
        System.Console.WriteLine("Good Stuff!");
        break;

    case "3":
        System.Console.WriteLine("Hope things improve!");
        break;

    case "2":
        System.Console.WriteLine("Oh, sorry to hear that!");
        break;

    case "1":
        System.Console.WriteLine("Dang. Hope your day gets better!");
        break;

    default:
        System.Console.WriteLine("Sorry, we don't understand. Please try again later.");
        break;
}

System.Console.WriteLine("How were you feeling yesterday? (1-5)");
string ratingInput = Console.ReadLine();

//we want to 'transform' ratingInput to an int.....
int yesterdayRating = int.Parse(ratingInput);

string response = yesterdayRating switch
{
    1=>"Dang. We hope today is a better day.",
    2=>"Oh, sorry to hear that",
    3=>"Hopefully things will get better this week",
    4=>"Good Stuff!",
    5=>"Thats great to hear!",
    _ => "Thats off the charts!"
};

System.Console.WriteLine(response);

//Challenge 
//We have 2 questions in our code:
//"How are you feeling today?
//"How were you feeling yesterday?

//we got 2 variables
//feelingRating
//yesterdayRating

//The challenge is to compare these two values and display how much better or worse 
//they are feeling today than yesterday.

//you don't have to use switch expressions for this challenge.
//use whatever works for you.

//Tools you should think about using:
//Converting strings to numbers
//Comparison Operators
//Conditionals