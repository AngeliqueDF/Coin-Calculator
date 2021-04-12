using System;
using System.Text.RegularExpressions;

namespace Coin_Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Coin Calculator!");
            Console.WriteLine("Enter the amount to convert");

            string enteredNumber = Console.ReadLine();
            decimal amount = 0;

            //if user enters . replace it with comma
            string pattern = @"\.";
            Regex rx = new Regex(pattern);
            bool match = rx.IsMatch(enteredNumber);
            if(match == true)
            {
                string formattedInput = rx.Replace(enteredNumber, ",");
                amount = Convert.ToDecimal(formattedInput);
            }
            else
            {
                amount = Convert.ToDecimal(enteredNumber);
            }


            Console.WriteLine($"{amount} cents is equal to...");

            //value
            decimal goldValue = 10;
            decimal silverValue = 5;
            decimal bronzeValue = 2.5m;

            decimal remainder = amount;

            //number of coins to get the amount
            decimal goldCoins = 0;
            decimal silverCoins = 0;
            decimal bronzeCoins = 0;


            if (amount > goldValue)
            {
                // find the maximum number of gold coins that fit into the amount
                goldCoins = Math.Floor(amount / goldValue);
                remainder = Math.Floor(amount % goldValue);
            }

            if(remainder > silverValue)
            {
                silverCoins = Math.Floor(remainder / silverValue);
                remainder %= silverValue;
            }

            if(remainder > bronzeValue)
            {
                bronzeCoins = Math.Floor(remainder / bronzeValue);
                remainder %= bronzeCoins;
            }

            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {bronzeCoins}");
            Console.WriteLine($"Remainder: {remainder}");

        }
    }
}
