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
            double money = 100, bet, profit;
            int dieTotal;

            string choice;

            Console.Write("Welcome to the Dice Game: ");
            Console.ReadLine();

            Die die1 = new Die();
            Die die2 = new Die();

            bool end = false ;
            while (!end)
            {
                Console.Clear();
                
                Console.WriteLine("What do you want to bet for");
                Console.WriteLine("1 - Doubles");
                Console.WriteLine("2 - Not Doubles");
                Console.WriteLine("3 - Even");
                Console.WriteLine("4 - Odd");
                Console.WriteLine("q - Quit");


                choice = Console.ReadLine();

                if (choice.ToLower() == "q")
                {
                    end = true;
                    continue;
                }

                if (choice != "1" && choice != "2" && choice != "3" && choice != "4")
                {
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, 4, or Q.");
                    Console.ReadKey();
                    continue;
                }



                Console.Write("How much do you want to bet: ");
                if (!double.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > money)
                {
                    Console.WriteLine("Invalid bet amount.");
                    continue;
                }

                die1.RollDie();
                die2.RollDie();
                dieTotal = die1.Roll + die2.Roll;
                Console.Clear();
                die1.DrawDie();
                die2.DrawDie();
                if (choice == "1" && die1.Roll == die2.Roll)  //doubles
                {
                    profit = bet * 2;
                    money += profit;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (choice == "2" && die1.Roll != die2.Roll) //not doubles
                {
                    profit = bet / 2;
                    money += profit;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");

                }
                else if (choice == "3" && dieTotal % 2 == 0) // even
                {
                    money += bet;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (choice == "4" && dieTotal % 2 != 0) // odd
                {
                    money += bet;
                    Console.WriteLine($"You rolled {die1.Roll} and {die2.Roll}. You win! Your new balance is ${money}");
                }
                else if (choice.ToLower() == "q")
                {

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
