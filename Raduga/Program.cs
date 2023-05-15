using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте анонимный метод для получения RGB значе-
//ния для цвета радуги. Цвет радуги передаётся в качестве
//параметра. Напишите код для тестирования работы метода.
namespace Raduga
{
    public delegate int[] GetRGB(Color color); 
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Color> colors = new List<Color>() { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.BlueViolet, Color.Violet };

            GetRGB getRGB = delegate (Color color)
            {
               
                return new int[3] { (int)color.R, (int)color.G, (int)color.B };

            };
            Console.ForegroundColor = ConsoleColor.Black;
            foreach (Color color in colors) 
            {
               
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine(color);
                var mas = getRGB(color);  //массив для 3 цветов
                Console.WriteLine($"RGB: R={mas[0]}, G={mas[1]},B={mas[2]}");

           

            }
            ConsoleColor[] rainbowColors = {
            ConsoleColor.Red,
            ConsoleColor.DarkYellow,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Blue,
            ConsoleColor.DarkBlue,
            ConsoleColor.Magenta,
        };
            foreach (var color1 in rainbowColors)
            {
                Console.BackgroundColor = color1;
                Console.WriteLine("----------------------------");

            }

            Console.ReadKey();
        }
    }
}
