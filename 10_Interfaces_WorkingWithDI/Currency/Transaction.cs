using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    //we want to track any exchanging currency
    public class Transaction
    {
        //private backing field -> we will use this for injection!!!
        private readonly ICurrency _currency;

        //This is where the DEPENDENCY INJECTION OCCURS!!!!!
        public Transaction(ICurrency currency)
        {
            _currency=currency;   

            //So whenever this 'Transaction' is constructed 
            //the time of day will be recorded.
            DateOfTransaction =DateTimeOffset.Now;

        }
        //property that describes what time of day a transaction occurs
        public DateTimeOffset DateOfTransaction { get; set; }

        //Make a custom method:
        public decimal GetTransactionAmount()
        {
            return _currency.Value;
        }

        //this allows us to use the name property on _currency
        public string GetTransactionType() => _currency.Name;

    }
