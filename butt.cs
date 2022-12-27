using ConsoleApp6;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Butt
    {
        public static void Load()
        {
            ConsoleKeyInfo butt = Console.ReadKey();
            if (butt.Key == ConsoleKey.Escape) Program.Close();
            else if (butt.Key == ConsoleKey.F1) Filear.Save();
            else
            {
                Console.Clear();
                Program.PathToFile(Filear.dir);
            }
        }
    }
}
