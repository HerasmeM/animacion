using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 60, b = 0;
            GenerarPiso();
            while (true)
            {
                GenerarMovimiento(ref a, ref b);
                if (a == 0)
                {
                    Console.Clear();
                    GenerarPiso();
                    a = 60;
                }
            }
        }

        static void Tubos(ref int a, ref int b)
        {
            Console.SetCursorPosition(a, b); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 1); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 2); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 3); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 4); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 5); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 6); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 7); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 8); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 9); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 10); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 11); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 12); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 13); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 14); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 15); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 16); Console.Write("████████████████████");

            Console.SetCursorPosition(a, b + 25); Console.Write("████████████████████");
            Console.SetCursorPosition(a, b + 26); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 27); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 28); Console.Write("  ████████████████");
            Console.SetCursorPosition(a, b + 29); Console.Write("  ████████████████");
        }

        static void GenerarMovimiento(ref int a, ref int b)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Tubos(ref a, ref b);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            a--;
            Tubos(ref a, ref b);
            System.Threading.Thread.Sleep(50);
        }


        static void GenerarPiso()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(61, 37);
            for (int i = 0; i <= 60; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(i, 30); Console.WriteLine("═");
                Console.SetCursorPosition(i, 31); Console.WriteLine("/");
            }
        }
    }

}

    

