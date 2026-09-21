using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 100, bet, profit;
            int dieTotal;

            
            Console.WriteLine("Welcome to the Dice Game!");
            Console.ReadLine();

            Die die1 = new Die();
            Die die2 = new Die();

            bool end = false ;
            while (!end)
            {
                Console.Clear();
                Console.WriteLine("Press 1 to quit");   
                Console.Write("How much do you want to bet: "); 
                bet = Convert.ToDouble(Console.ReadLine());

                
                die1.RollDie();
                die2.RollDie();
                dieTotal = die1.Roll + die2.Roll;

                die1.DrawDie();
                die2.DrawDie();
                if (die1.Roll == die2.Roll)
                {
                    profit = bet * 2;
                    money += profit;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (die1.Roll != die2.Roll)
                {
                    profit = bet / 2;
                    money += profit;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");

                }
                else if (dieTotal == 2 || dieTotal == 4 || dieTotal == 6 ||  dieTotal == 8 || dieTotal == 10 || dieTotal == 12)
                {
                    money += bet;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (dieTotal == 3 || dieTotal == 5 || dieTotal == 7 || dieTotal == 9 || dieTotal == 11)
                {
                    money += bet;
                    die1.DrawDie();
                    die2.DrawDie();
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else
                {
                    money -= bet;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You lose! Your new balance is ${money}");
                }

                    Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
