using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace _10_WDI_Test_Refactor;

[TestClass]
public class TransactionTests
{
    //Lets start by defining a few thing s we'll need for our tests
    //We are interacting with money, so let's very quickly rack up some debt
    private decimal _debt;

    //Let's write a method that also let's us pay our debt off
    //Write a simple method that takes in an ICurrency and pays it towards the debt
    //This way the method is not depenent on any specific type of currency
    private void PayDebt(ICurrency payment)
    {
        _debt-=payment.Value;
        System.Console.WriteLine($"You have paid ${payment.Value} towards your debt.");
    }
    //Finally, before we start writing our tests, lets add a way to reset our debt for 
    //each test
    //We can do this with a TestInitialize method, which fires off before each test
    [TestInitialize]
    public void Arrange()
    {
        _debt=9000.01m;
    }

    //Alright now we can move on testing more of our Currency and Transaction classes
    //Let's start by testing our PayDebt method to make sure it works as intended
    [TestMethod]
    public void PayDebtTest()
    {
        //we need to inject an object that implements ICurrency 
        //the type does not matter, as long as it implements the interface correctly

        //This also means that we can initialize the objects as argument in our PayDebt() method
        PayDebt(new Dollar());
        PayDebt(new ElectronicPayment(315.52m));

        //We're going to be able to see the console output, but let's also assert this 
        //First let's calculate what our total should be.
        decimal expectedDebt = 9000.01m - 316.52m; //--(1 dollar plus the electronic payment)

        //We can now compare this calculated expected to the field we have manipulated
        Assert.AreEqual(expectedDebt,_debt);
    }

    //Now we have seen what it's like working with a method that takes in an interface
    //Let's now work with a class that we cna inject a dependency into
    [TestMethod]
    public void InjectingIntoConstructors()
    {
        //We eclare our objects that implement ICurrency
        //These types don't really matter, so feel free to make as many or as few
        //We just want to sho at least two
        var dollar = new Dollar();
        var ePayment = new ElectronicPayment(243.71m);

        //We now pass them through into the new Transaction class'es constructor
        var firstTransaction = new Transaction(dollar);
        var secondTransaction = new Transaction(ePayment);

        //We can now call the methods in the class we passed them into
        //Now reguardless of what was passed into the Transaction we can call the
        //same methods
        //The Transaction's methods do not care what class type there is except that
        //it implements ICurrency
        //Make sure to brekpoint though this code:
        System.Console.WriteLine(firstTransaction.GetTransactionType());
        System.Console.WriteLine(secondTransaction.GetTransactionType());
    
        //We can now write some Assert statements
        Assert.AreEqual("Dollar",firstTransaction.GetTransactionType());
        
        Assert.AreEqual("Electronic Payment",secondTransaction.GetTransactionType());
        Assert.AreEqual(243.71m, secondTransaction.GetTransactionAmount());

    }

    //Let's show another example, this time with a few more Transactions
    //Here's another quick example that shows a list of Transactions being made
    //We can call the same method reguardless of what has been passed into the constructor
    [TestMethod]
    public void MoreExamples()
    {
        //Don't forget to bring in our collections using statement
        //Here we're just making a new collection of Transactions so we can iterate through
        //them
        var list = new List<Transaction>
        {
            new Transaction(new Dollar()),
            new Transaction(new ElectronicPayment(231.95m)),
            new Transaction(new Dime()),
            new Transaction(new Dollar()),
            new Transaction(new Penny())
        };

        //Now we want to writ a foreach loop that writes out the transaction's type, amount, and
        //date
        //Give the studens a few minutes to work through this before going over it
        foreach(var transaction in list)
        {
            //you don't need to declare variables for these values if you don't want
            //its just easier for beginners
            var type = transaction.GetTransactionType();
            var amount = transaction.GetTransactionAmount();

            //We can just write out to the console some value
            //This is just another demonstration, so we don't have to make any assertions
            System.Console.WriteLine($"{type} ${amount} {transaction.DateOfTransaction}");
        }
    }
   
}