//Booleans

//can hold true or false values

bool isCool = false;
isCool = true;

//Booleand logical operators
//Operators that perform logical operations and assessments.
//these use the keywords AND, OR, NOT ,etc.

//NOT
//C# has the logical negation operator, or more commonly known as the bang operator (!)
// !isCool evaluates to the opposite of whatever value isCool is holding

//And
//C# uses ampersands (&) to indicate AND statements
// A single apmpersand evaluates both conditions always,
//where a double apmpersand only evaluates the right side if its required.

//OR
//C# use pipes (|) to indicate OR statements
//Similar to AND, one pipe checks both conditions and
//two pipes evaluates left side first then the right

//XOR
//C# uses the caret character (^) to indicate XOR statements.
//--Boolean Logical Operators
//Negation Operator
bool isTrue =!false; //true
bool isFalse = !true; //false

//And Operator
bool trueAndExample = true && true; //true -> both of these HAVE to be true!
bool falseAndExample = true && false; //false

//Or Operator
bool trueOrExample = true || false; //only one of these have to pass!
bool falseOrExample = false || false; 

//XOR Operator 
bool trueExclusiveOr = true ^ false; //true;
bool falseExclusiveOr = true ^ true; //false;
bool falseExclusiveOr2 = false ^ false; //false;

System.Console.WriteLine($"NOT False = {isTrue}");
System.Console.WriteLine($"False AND True= {falseAndExample}");
System.Console.WriteLine($"True OR True = {trueOrExample}");
System.Console.WriteLine($"True XOR True = {trueExclusiveOr}");
System.Console.WriteLine($"False XOR False = {falseExclusiveOr2}");

//Comparison Operators

//Equal 
//To declare that values are equal, you must use two equal signs (==).

//Not Equal
//In C# we use (!=) to indicate the values given are not equal

//Greater Than 
//C# use the (>) indicates Greater than. 
//Evaluates to True if the left side is indeed greater than the right side

//Greater Than or Equal
//C# uses the (>=) operator
//use angle bracket but uses equal sign to end or indicate that it can include this value.

//Less Than
//Less than is same concept as greater than except 
//it uses the caret that faces to the right(<)
//This does not include equal values. 10 is not less than 10.

//Less than Or Equal 
//Same concept as Greater than or equal to. Execpt it uses (<=)

//Examples:
bool isGreaterThan = 10 > 10;
bool isGreaterThanOrEqualTo = 10 >= 10;
System.Console.WriteLine($"10 > 10 is {isGreaterThan}, and 10 >= 10 is {isGreaterThanOrEqualTo}");

bool isLessThan = 5 < 5 ;
bool isLessThanOrEqualTo = 5 <= 5 ;
System.Console.WriteLine($"5 < 5 is {isLessThan}, while 5 <= 5 is {isLessThanOrEqualTo}");

bool equality = 17 == 9;
bool inequality = 17 !=9;
System.Console.WriteLine($"17 == 9 and 17 != 9 are {equality} and {inequality}, respectively.");