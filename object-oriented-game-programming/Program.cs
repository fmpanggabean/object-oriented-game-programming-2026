using System;

namespace object_oriented_game_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // pembuatan variabel
            string playerName = "Hermawan";
            int playerExp = 0;
            int playerHealth = 55;
            int playerMaxHealth = 100;

            // print out string
            Console.WriteLine("=================================");
            Console.WriteLine($"Player Name\t: {playerName}");
            Console.WriteLine($"Player Exp\t: {playerExp}");
            Console.Write($"Player Health\t: {playerHealth} / {playerMaxHealth}");

            #region health bar
            // print out health bar
            Console.Write("|");
            for (int i=0; i<10; i++)
            {
                if (i < playerHealth * 10 / playerMaxHealth)
                {
                    Console.Write("█");
                }
                else
                {
                    Console.Write("░");
                }
            }
            Console.Write("|");
            #endregion

            Console.WriteLine("");
            Console.WriteLine("=================================");
        }
    }
}
