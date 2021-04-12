using System;

namespace Coin_Calculator
{
    class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Enter the amount to convert");
      double amount = Math.Round(Convert.ToDouble(Console.ReadLine()));

      Console.WriteLine($"{amount} cents is equal to...");

      int goldValue = 10;
      int silverValue = 5;

      // find the maximum number of gold coins that fit into the amount
      double goldCoins = Math.Floor(amount/goldValue);
      double remainder = amount % goldValue;

      // find the maximum number of silver coins that fit into the remainder
      double silverCoins = Math.Floor(remainder / silverValue);
      remainder = remainder % silverValue;

      Console.WriteLine($"Gold coins: {goldCoins}");
      Console.WriteLine($"Silver coins: {silverCoins}");
      Console.WriteLine($"Remainder: {remainder}");

    }
  }
}
