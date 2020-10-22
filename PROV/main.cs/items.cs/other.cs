using System.Collections.Generic;
using System;

namespace code
{
    public class customer
    {
        //här är samma sak fast för customer klassen!
        Random generator = new Random();
        public string buyerSay;
        public int buyerAmount;
        public List<int> buyers = new List<int>();
        public int buyerBalance;
        public customer()
        {
            //och bara en oanvänd randomizer här :/
            buyerBalance = generator.Next(1000);
            
        }
    }
}
