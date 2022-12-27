using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        public static List<MyDataFile> DataList = new List<MyDataFile>() {
            new MyDataFile("Долг на январь", 200),
            new MyDataFile("Долг на февраль", 300),
            new MyDataFile("Выплачено", 250),
            new MyDataFile("Долг", 250)
        };

        static void Main(string[] args)
        {
            Console.WriteLine("├ Введите файл который хотите открыть (.txt, .json, .xml)");

            Console.Write($"\n{Filear.url} > ");
            string input = Console.ReadLine();
            PathToFile(input);
        }

        public static void PathToFile(string readLine)
        {
            Filear.dir = readLine;

            if (File.Exists(Filear.url + "/" + Filear.dir))
            {
                Console.Clear();
                Filear.Open();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Файл: {Filear.dir} - не найден!");

                if (Filear.Create())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Создаю новый файл: {Filear.url}/{Filear.dir}");
                }
                else Console.WriteLine($"Файл: {Filear.dir} - не удалось создать");

                Close();
            }
        }

        public static void Close()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nСпасибо что воспользовались текстовый редактором! Не забудьте поменять код :3");
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }
    }
}
