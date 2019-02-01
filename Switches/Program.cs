using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Some Text: ");
            do//keeps executing the script so you can keep typing
            {
                ColorRandomizer();
                Console.ReadKey();
            } while (true);
        }

        private static void ColorRandomizer()//Generates a random number from 1 to 16 and passes it into the color switcher method
        {
            Random rnd = new Random();
            int color = rnd.Next(1, 16);
            Console.ForegroundColor = Switcher(color);
        }

        public static ConsoleColor Switcher(int a)//takes an int value which is then routed to output a ConsoleColor
        {
            switch (a)
            {
                case 1:
                    return ConsoleColor.Black;
                case 2:
                    return ConsoleColor.Blue;
                case 3:
                    return ConsoleColor.Cyan;
                case 4:
                    return ConsoleColor.DarkBlue;
                case 5:
                    return ConsoleColor.DarkCyan;
                case 6:
                    return ConsoleColor.DarkGray;
                case 7:
                    return ConsoleColor.DarkGreen;
                case 8:
                    return ConsoleColor.DarkMagenta;
                case 9:
                    return ConsoleColor.DarkRed;
                case 10:
                    return ConsoleColor.DarkYellow;
                case 11:
                    return ConsoleColor.Gray;
                case 12:
                    return ConsoleColor.Green;
                case 13:
                    return ConsoleColor.Magenta;
                case 14:
                    return ConsoleColor.Red;
                case 15:
                    return ConsoleColor.White;
                case 16:
                    return ConsoleColor.Yellow;
                default:
                    return ConsoleColor.White;
            }
        }
    }
}
