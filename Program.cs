using System.Threading;
using System;

namespace ConsoleMenu
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool closeCicle = true;

            while(closeCicle)
            {
            string[] menuComands = { "Изменить цвет фона консоли на зеленый ", "Изменить цвет шрифта на красный ", "Цвет консоли по умолчанию ", "Сигнал консоли" };
            Console.WriteLine("Ниже вы видите команды для изменения консоли");
            Console.WriteLine("При нажатии любой другой клавиши произойдет выход из программы");
            int outputCorrection = 1;

            for(int i=0;i<menuComands.Length;i++)
            {

                Console.WriteLine(menuComands[i]+" - "+(i+outputCorrection));
            }
            switch (Console.ReadLine())
            {
                case "1":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
                case "2":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case "3":
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    break;
                case "4":
                    Console.Beep();
                    Console.Clear();
                        break;
                default:
                    closeCicle = false;
                    break;
            } 
            }
        }
    }
}
