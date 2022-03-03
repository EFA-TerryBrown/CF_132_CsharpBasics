//C# Types 

//camel-cased fist letter of the name is lowerCased and every other name is Capitalized

//bool -> true or false
bool isLoggedIn = true;
System.Console.WriteLine(isLoggedIn);

//integers, or int -> these are whole numbers
int age =42;
System.Console.WriteLine(age);

//decimal -> very precise 
//need m suffix to show that it is a decimal
decimal accountBalance =9000.01m; // 9_000_01m
System.Console.WriteLine(accountBalance);

int i = 0;             //32 bit integer value
short sh = 32767;     //16 bit integer value
Int16 anotherShortExample =32000;
byte by = 255;      // a group of binary digits (usually eight ) operated on as a unit.
string s = "hey!"; //a collection of characters 
                  //(this is a reference type so it defaults to null)
char c = 'i';    //represents a single character

string s2 = @"a\tree"; //use the @ specify a directory

bool b = false;    //true or false value

long L = 7;       //is a LARGE integer value. x2 more LARGE. 
                 // -9_223_372_036_854_775_808 to 9_223_372_036_854_775_807
                 //(nine quintillion two hundred twenty-three quadrillion three hundred seventy-two 
                 //trillion thirty-six billion eight hundred fifty-four million 
                 //seven hundred seventy-five thousand eight hundred seven)

decimal d = 99.999999m; // 'm' 128-bit percision, range of 28-29 decimal places (MONEY)

double db = 7.80000d; // 'd' Has 15-16 digit percision with a 64-bit size 

float f = 10.8f; // 'f' float is stored in 32-bits, half the size of a double;

int? ni = null;  // A '?' after the data type allows the value to be null.
                // null means 'ni' can have a value or be null(nothing).

//Dealing with Decimals
//we can type as many decimal places that we want for a given type
//but, things change during compile time (dotnet run....)
Console.WriteLine(1.2578907289045789789789789787897f);
Console.WriteLine(1.2578907289045789789789789787897d);
Console.WriteLine(1.2578907289045789789789789787897m);

//use our pastryTypes:
PastryType myPastry = PastryType.Croissant;
PastryType anotherOne = PastryType.Cake;

//All number types in C# are structs (value types)
//They are Emutable -> you cannot change its initial value.
//the value of 4 is always 4. 
//they can be grabbed very quickly b/c they live on the stack.

//A common struct is DateTime 
DateTime Today  = DateTime.Today;

//We can also make our own 'DateTime'
//using 'new' keyword -> allocating space in memory for this Date.
DateTime birthDay = new DateTime(1972,06,20);


