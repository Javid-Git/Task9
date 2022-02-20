using System;

namespace Task9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsul Haqqinda Melumat");

            Milk milk = new Milk("PalSud");
            milk.Price = 1;
            milk.Count = 20;
            milk.TotalIncome = 0; 
            milk.Volume = 0.75;
            milk.FatRate = 3.2;

            Console.WriteLine($"Name: {milk.Name}\nPrice: {milk.Price}\nCount: {milk.Count}\nVolume: {milk.Volume}\nFat Rate: {milk.FatRate}");
            Console.WriteLine("Nece dene satilmasi istenilir?");
            milk.Sell(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
