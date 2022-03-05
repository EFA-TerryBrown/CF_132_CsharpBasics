
//Foreach syntax
//foreach(declaredIterator in enumberableCollection)
//{
//body
//}

//Ex:
string instructorName = "Amanda";
// make a enumberable Collection
string[] instructors = new string[] { "Michael", "Joshua", instructorName };

//loop through this
//using temp variable name called instructor
//that represents a single instructor called 'instructor'
//for each iteration of the loop
foreach (string instructor in instructors)
{
    System.Console.WriteLine(instructor);
}

//Challenge
//Make another foreach loop
//Declare a new array of intergers
int[] intArray = new int[]
{
    1,
    2,
    -3,
    4,
    5,
    0
};
//Iterate over this array with a foreach loop
foreach (int value in intArray)
{
    //write to the console whether or not the numbers are negative , positive, or neutral 
    if(value <0)
    {
        System.Console.WriteLine("This is a negative number!");
    }
    else if(value>0)
    {
        System.Console.WriteLine("This is a positive number!");
    }
    else
    {
        System.Console.WriteLine("This is a neutral number!");
    }

//    switch(value)
//    {
//        case 1:
//        case 2:
//        case 4:
//        case 5:
//        System.Console.WriteLine("This is a positive number!");
//        break;
//        case -3:
//        System.Console.WriteLine("This is a negative number!");
//        break;
//        default:
//         System.Console.WriteLine("This is a neutral number!");
//         break;
//    }
}