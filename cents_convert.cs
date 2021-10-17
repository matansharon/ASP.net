using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");
      Console.WriteLine("Please enter an amount of money...");
      double amt=Convert.ToDouble(Console.ReadLine());
      
      double gold_coin=10.0;
      double silver_coin=5.0;
      double res_gold=Math.Floor(amt/gold_coin);
      int res_silver=0;
      
      if(amt%10>5) res_silver=1;
      double res_bronze=amt-(res_gold*10+res_silver*5);
      Console.WriteLine($"{amt} cents is equal to...\nGold coins: {res_gold}\nSilver coins: {res_silver}\nBronze coins: {res_bronze}");
      
    }
  }
}
