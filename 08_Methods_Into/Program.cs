//Methods

//Usually made in class, but we are going to use them here.

//Small machines that can perform modular tasks

//They can give you back something (return value)

//or they can return void (nothing)
//1     //2             //3    
//public void SayHello(string name){
//4
//Console.WriteLine($"Hello {name}!");
//}

//1 Access Modifier=> public (everyone can use), private (only the class can use)
//protected (only inheriting classes can use)
//internal (only used inside of 'this' assembly)
//2 return type=> in this case it returns void (or nothing)
//3 Method Signature => MethodName and it's parameters (useful when using MethodOverloading)
//4 Body => the code thats being executed.

//void returns 'nothing'
//passing a parameter of type string -> this time its called 'name'
//into this SayHello 'machine'
void SayHello(string name)
{
    System.Console.WriteLine($"Hello, {name}!");
}

//we have to call the method to use it!
SayHello("Tim");
SayHello("Bill Burr");

//this method returns nothing and 
//has no parameters
void Greeting()
{
    System.Console.WriteLine("Hello!");
}
//Call the method
Greeting();

//Add 2 ints together -> 2 parameters
int AddMe(int ValueA, int ValueB)
{
    int ans = ValueA + ValueB;
    return ans;
}

//the plan is to store this into a variable
int sum = AddMe(2, 5);
System.Console.WriteLine($"sum: {sum}");

//subtracting 2 double and give back an int

int SubtractMe(double ValueA, double ValueB)
{
    double ans = ValueA - ValueB;
    return Convert.ToInt32(ans);
    // return Convert.ToInt32(ValueA-ValueB);
}

System.Console.WriteLine(SubtractMe(10, 5));

double SquareMe(int value)
{
    double ans = value * value;
    return ans;
}

//nested method A:
//AddMe will be called first
//the answer will be Squared by SquareMe Method
System.Console.WriteLine(SquareMe(AddMe(10, 2))); //144

//Method that takes in as many parameters as I want
int CrazyMath_AddUs(params int[] values)
{
    int startingPoint = 0;

    //use a foreach loop to loop through all of the values
    foreach (int value in values)
    {
        startingPoint += value;
    }
    //return the values (added)
    return startingPoint;
}

int addedValues = CrazyMath_AddUs(1, 7, 8, 9, 22, 12);
System.Console.WriteLine(addedValues);


Random _random = new Random();
void GetRandomGreeting()
{
    string[] availableGreetings =
    {
        "Hello",  //0
        "Howdy",  //1
        "Hola",   //2
        "Yo",     //3
        "Greetings"  //4
    };

    //getting the random number
    int randomNumber = _random.Next(0, availableGreetings.Length);

    //give me the element at this random number:
    string randomGreeting = availableGreetings.ElementAt(randomNumber);

    System.Console.WriteLine($"{randomGreeting}");  
}
//{...} represents the scope of the method
GetRandomGreeting();