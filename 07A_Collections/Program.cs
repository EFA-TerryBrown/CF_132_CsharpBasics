using System.Collections.Generic;

//heres what NOT to do!!!!
object[] stuff = new object[5];
stuff[0] = "Terry";
stuff[1] = 1;
stuff[2] = 44.75f;
stuff[3] = "Bill bob";

//WE NEED TYPE SAFETY!!!!
//Array -> THESE ARE ALWAYS FIXED VALUES , ALL COLLECTIONS START FROM ZERO
//this is a collection of 'char'
string stringExample = "Hello World";

//Array of type string
string[] stringArray =
{
    "Hello",
    "World",
    "Why",
    "is it",
    "Always",
    stringExample,
    "?"
};

string thirdItem = stringArray[3]; // 'is it' is the output
System.Console.WriteLine(thirdItem);

//change the value of the first item in stringArray[]
stringArray[0] = "Hey there.";
System.Console.WriteLine(stringArray[0]);

//--Lists<T>
// can only be used with: System.Collections.Generic (using statement)
List<string> listOfStrings = new List<string>();
List<int> listOfIntergers = new List<int>();

listOfStrings.Add("First string of our list.");
listOfIntergers.Add(46210);

System.Console.WriteLine(listOfIntergers[0]);

//--Queues
//This is a line
//Whoever is first in line is FIRST to be serviced.
Queue<string> firstInFirstOut = new Queue<string>();

//this is to add to the queue:
firstInFirstOut.Enqueue("I'm First");
firstInFirstOut.Enqueue("I'm Second");

//what we can do is 'see who is next in line' 
string seeWhoIsNext = firstInFirstOut.Peek();
System.Console.WriteLine(seeWhoIsNext);

//removing an item:
//we cannot remove any item we want,
//we can only remvoe who is first
string removedItem = firstInFirstOut.Dequeue();
System.Console.WriteLine($"removed : {removedItem}");

//making sure the value is removed
string whoIsNextInLine = firstInFirstOut.Peek();
System.Console.WriteLine($"next: {whoIsNextInLine}");
System.Console.WriteLine("Testing Testing");

//--Dictionaries <TKey,TValue>
//there can only be ONE KEY!
Dictionary<int,string> keyAndValue = new Dictionary<int, string>();

//add to the dictionary:
keyAndValue.Add(7,"Agent");
// keyAndValue.Add(7,"Bob");

string valueSeven = keyAndValue[7];
System.Console.WriteLine(valueSeven); //Agent

//--Other Collections
SortedList<int,string> sortedKeyandValue = new SortedList<int, string>();
HashSet<int> uniqueList = new HashSet<int>();
Stack<string> lastInFirstOut = new Stack<string>();

//-------------------------------------------------------------

//How to deal with random numbers:
Random rng = new Random();

// int randomNumber = rng.Next();
//give me number between 5 and 20
//5 is inclusive and seven is exclusive (cant get the number 7)
int randomNumber = rng.Next(5,7);
System.Console.WriteLine(randomNumber);