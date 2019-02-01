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
            int color = rnd.Next(1, 15);
            Console.ForegroundColor = Switcher(color);
        }

        public static ConsoleColor Switcher(int a)//takes an int value which is then routed to output a ConsoleColor
        {
            var colorList = new List<ColorEntity> {
                new ColorEntity{ColorName = ConsoleColor.DarkCyan, ColorId = 1},
                new ColorEntity{ColorName = ConsoleColor.Blue, ColorId = 2},
                new ColorEntity{ColorName = ConsoleColor.Cyan, ColorId = 3},
                new ColorEntity{ColorName = ConsoleColor.DarkBlue, ColorId = 4},
                new ColorEntity{ColorName = ConsoleColor.DarkGray, ColorId = 5},
                new ColorEntity{ColorName = ConsoleColor.DarkGreen, ColorId = 6},
                new ColorEntity{ColorName = ConsoleColor.DarkMagenta, ColorId = 7},
                new ColorEntity{ColorName = ConsoleColor.DarkRed, ColorId = 8},
                new ColorEntity{ColorName = ConsoleColor.DarkYellow, ColorId = 9},
                new ColorEntity{ColorName = ConsoleColor.Gray, ColorId = 10},
                new ColorEntity{ColorName = ConsoleColor.Green, ColorId = 11},
                new ColorEntity{ColorName = ConsoleColor.Magenta, ColorId = 12},
                new ColorEntity{ColorName = ConsoleColor.Red, ColorId = 13},
                new ColorEntity{ColorName = ConsoleColor.White, ColorId = 14},
                new ColorEntity{ColorName = ConsoleColor.Yellow, ColorId = 15},
            };



            var result = colorList.SingleOrDefault(x => x.ColorId == a);
            return result.ColorName;
        }
    }
}
