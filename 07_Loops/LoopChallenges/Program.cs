//Loops Challenges:

//Bronze:
//Write a for loop to print the numbers 500 through 525.
//starting point i = 500; (initialization)
//boolean expression i<=525 (the loop will run as long as this is TRUE)
//i will increment up by one as long as bool value is TRUE
for (int i = 500; i <= 525; i++)
{
    System.Console.WriteLine(i);
}



//Silver:
//Create a for loop to print the numbers from 0-100 by 5's.
for (int i = 0; i <= 100; i += 5)
{
    System.Console.WriteLine(i);
}

int k = 0;
System.Console.WriteLine("------------While Version-------------------");
while (k <= 100)
{
    System.Console.WriteLine(k);
    k += 5;
}


//Gold:
//Create a for loop to print the numbers 1-100. 
for (int i = 1; i <= 100; i++)
{
    //If it's divisible by both 3 and 5, print 'FizzBuzz' otherwise print the number.
    if (i % 3 == 0 && i % 5 == 0)
    {
        System.Console.WriteLine($"{i}: FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        //If the number is divisible by 3, print 'Fizz' instead of the number. 
        System.Console.WriteLine($"{i}: Fizz");
    }
    else if (i % 5 == 0)
    {
        //If it's divisible by 5, print 'Buzz', instead of the number. 
        System.Console.WriteLine($"{i}: Buzz");
    }
}