using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _10_Interfaces_WDI_Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void PennyTests()
    {
        ICurrency penny = new Penny();
        
        Assert.AreEqual(.01m,penny.Value);
    }

    [TestMethod]
    public void DimeTests()
    {
        ICurrency dime = new Dime();
        
        Assert.AreEqual(.10m,dime.Value);
    }

    [TestMethod]
    public void DollarTests()
    {
        ICurrency dollar = new Dollar();
        
        Assert.AreEqual(1.00m,dollar.Value);
        Assert.AreEqual("Dollar",dollar.Name);
    }

    //DataTestMethod Attribute
    [DataTestMethod]
    [DataRow(100.2)]
    [DataRow(37.12)]
    [DataRow(1.50)]
    [DataRow(19)]
    public void EPayTest(double value)
    {
        decimal convertedValue = Convert.ToDecimal(value);

        var ePayment = new ElectronicPayment(convertedValue);

        //assertions
        Assert.AreEqual(convertedValue,ePayment.Value);
        Assert.AreEqual("Electronic Payment", ePayment.Name);
    }
}

