using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Die
    {
        private int _sides;
        public int _roll;
        static private Random _generator = new Random();

        public Die()
        {
            _sides = 6;
            _roll = _generator.Next(1, _sides + 1);
        }

        //public Die(int sides)
        //{
        //    _sides = sides;
        //    _generator = new Random();
        //    _roll = _generator.Next(1, _sides + 1);
        //}
        //Accessor Properties
        public int Roll
        {
            get { return _roll; }

        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1, _sides + 1);
        }

        public void DrawDie()
        {

            if (_roll == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("|_______|");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 2)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| *     |");
                Console.WriteLine("|     * |");
                Console.WriteLine("|_______|");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| *     |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("|     * |");
                Console.WriteLine("|_______|");
                Console.ForegroundColor = ConsoleColor.White;

            }
            else if (_roll == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|       |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|_______|");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 5)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|   *   |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|_______|");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (_roll == 6)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" _______");
                Console.WriteLine("|       |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("| *   * |");
                Console.WriteLine("|_______|");
                Console.ForegroundColor = ConsoleColor.White;

            }

        }
    }
}
