using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = 100, bet, profit, choice;
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
                Console.WriteLine("What do you want to bet for");
                Console.WriteLine("1 - Doubles");
                Console.WriteLine("2 - Not Doubles");
                Console.WriteLine("3 - Even");
                Console.WriteLine("4 - Odd");
                choice = Convert.ToDouble(Console.ReadLine());

                //if (!double.TryParse(Console.ReadLine(), out choice) || choice <= 0 )
                //{
                //    Console.WriteLine("Invalid bet amount. Please enter a positive number less than or equal to your current balance.");
                //    continue;
                //}

                Console.Write("How much do you want to bet: "); 
                bet = Convert.ToDouble(Console.ReadLine());

                if (!double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > money)
                {
                    Console.WriteLine("Invalid bet amount. Please enter a positive number less than or equal to your current balance.");
                    continue;
                }

                die1.RollDie();
                die2.RollDie();
                dieTotal = die1.Roll + die2.Roll;

                die1.DrawDie();
                die2.DrawDie();
                if (/*!double.TryParse(Console.ReadLine(), out choice) || */choice == 1 && die1.Roll == die2.Roll)  //doubles
                {
                    profit = bet * 2;
                    money += profit;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (choice == 2 && die1.Roll != die2.Roll) //not doubles
                {
                    profit = bet / 2;
                    money += profit;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");

                }
                else if (choice == 3 && dieTotal == 2 || dieTotal == 4 || dieTotal == 6 ||  dieTotal == 8 || dieTotal == 10 || dieTotal == 12) //even
                {
                    money += bet;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (choice == 4 && dieTotal == 3 || dieTotal == 5 || dieTotal == 7 || dieTotal == 9 || dieTotal == 11)    //odd
                {
                    money += bet;
                    die1.DrawDie();
                    die2.DrawDie();
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else     //anthing else
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
