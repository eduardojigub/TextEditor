using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Open File");
            Console.WriteLine("2 - Create File");
            Console.WriteLine("0 - Leave");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }
        static void Open()
        {

        }
        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Type your text here (ESC to leave)");
            Console.WriteLine("--------------------");
            string text = "";
            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }
        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("In which path you want to save the file?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"The file {path} was saved sucessfully");
            Console.ReadLine();
            Menu();
        }
    }
}
