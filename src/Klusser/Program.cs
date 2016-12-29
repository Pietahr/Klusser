using System;
using Klusser.Models;

namespace Klusser
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chore chore = new Chore("Dweilen",100);

            Console.WriteLine(chore.DateOfChore);
            Console.ReadLine();
        }
    }
}
