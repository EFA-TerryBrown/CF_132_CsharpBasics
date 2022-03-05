//Loops
//purpose use to repeate operations w/n an application
//We have to define the operation, functionalit, and 'wrap' a loop around it.
//loop will have specific iterations it needs to execute before ending.

//Declare a variable -> used for our loops boolean expression
int number =0; //starting point

//While the value in number is less than or equal to 100 then do the following:
while (number <=100)
{
    //writing the value of number to the console
    System.Console.WriteLine(number);
    //incrementing number by 5 -> each iteration.
    number+=5;
}

//Infinate loops (our enemy....)
// while(number == 0)
// {
//     System.Console.WriteLine("Oh, S**t!");
// }

//what can we do to kinda control this behavior
int value2 = 100;
while (value2 > 0)
{
    value2--;
    if(value2 == 90)
    {
        System.Console.WriteLine("We just Jumped out of the while loop!");
        break;
    }
    if(value2 == 80)
    {
        System.Console.WriteLine("Well just return (leave the loop)");
        return;
    }
    if(value2==10)
    {
        System.Console.WriteLine("We'll just carry on with the loop.");
        continue;
    }
}