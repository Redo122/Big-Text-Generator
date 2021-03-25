﻿using System;
using System.IO;

namespace Big_Text_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = { "╔═════╗", "╔════╗ ", "╔═════╗", "╔═════╗", "╔═════╗", "╔═════╗", "╔═════╗", "╔═╗ ╔═╗", "╔═══╗", "   ╔═╗", "╔═╗ ╔═╗", "╔═╗    ", " ╔══╗    ╔══╗ ", "╔══╗  ╔═╗", "╔═════╗", "╔═════╗", "╔═════╗ ", "╔═════╗", "╔════╗", "╔═════╗", "╔═╗ ╔═╗", "╔═╗  ╔═╗", "╔═╗  ╔══╗  ╔═╗", "╔══╗╔══╗", "╔═╗   ╔═╗", "╔═════╗" };
            string[] line2 = { "║ ╔═╗ ║", "║ ╔╗ ║ ", "║ ╔═══╝", "╚╗ ╔╗ ║", "║ ╔═══╝", "║ ╔═══╝", "║ ╔═╗ ║", "║ ║ ║ ║", "╚╗ ╔╝", "   ║ ║", "║ ║╔╝╔╝", "║ ║    ", "╔╝  ╚╗  ╔╝  ╚╗", "║  ╚╗ ║ ║", "║ ╔═╗ ║", "║ ╔═╗ ║", "║ ╔═╗ ║ ", "║ ╔═╗ ║", "║ ╔══╝", "╚═╗ ╔═╝", "║ ║ ║ ║", "║ ║  ║ ║", "║ ║ ╔╝  ╚╗ ║ ║", "╚╗ ╚╝ ╔╝", "║ ╚╗ ╔╝ ║", "╚══╗  ║" };
            string[] line3 = { "║ ║ ║ ║", "║ ╚╝ ╚╗", "║ ║    ", " ║ ║║ ║", "║ ╚══╗ ", "║ ╚══╗ ", "║ ║ ╚═╝", "║ ╚═╝ ║", " ║ ║ ", "   ║ ║", "║ ╚╝╔╝ ", "║ ║    ", "║ ╔╗ ╚╗╔╝ ╔╗ ║", "║ ╔╗╚╗║ ║", "║ ║ ║ ║", "║ ╚═╝ ║", "║ ║ ║ ║ ", "║ ╚═╝ ║", "║ ╚══╗", "  ║ ║  ", "║ ║ ║ ║", "║ ╚╗╔╝ ║", "║ ║╔╝ ╔╗ ╚╗║ ║", " ╚╗  ╔╝ ", "╚╗ ╚═╝ ╔╝", "  ╔╝ ╔╝" };
            string[] line4 = { "║ ╚═╝ ║", "║ ╔═╗ ║", "║ ║    ", " ║ ║║ ║", "║ ╔══╝ ", "║ ╔══╝ ", "║ ║╔══╗", "║ ╔═╗ ║", " ║ ║ ", "╔═╗║ ║", "║ ╔╗╚╗ ", "║ ║    ", "║ ║╚╗ ╚╝ ╔╝║ ║", "║ ║╚╗╚╝ ║", "║ ║ ║ ║", "║ ╔═══╝", "║ ║ ║ ║ ", "║ ╔╗ ╔╝", "╚══╗ ║", "  ║ ║  ", "║ ║ ║ ║", "╚╗ ╚╝ ╔╝", "║ ╚╝ ╔╝╚╗ ╚╝ ║", " ╔╝  ╚╗ ", " ╚═╗ ╔═╝ ", " ╔╝ ╔╝ " };
            string[] line5 = { "║ ╔═╗ ║", "║ ╚═╝ ║", "║ ╚═══╗", "╔╝ ╚╝ ║", "║ ╚═══╗", "║ ║    ", "║ ╚╝  ║", "║ ║ ║ ║", "╔╝ ╚╗", "║ ╚╝ ║", "║ ║╚╗╚╗", "║ ╚═══╗", "║ ║ ╚╗  ╔╝ ║ ║", "║ ║ ╚╗  ║", "║ ╚═╝ ║", "║ ║    ", "║ ╚═╝ ╚╗", "║ ║║ ╚╗", "╔══╝ ║", "  ║ ║  ", "║ ╚═╝ ║", " ╚╗  ╔╝ ", "╚╗  ╔╝  ╚╗  ╔╝", "╔╝ ╔╗ ╚╗", "   ║ ║   ", "╔╝  ╚═╗" };
            string[] line6 = { "╚═╝ ╚═╝", "╚═════╝", "╚═════╝", "╚═════╝", "╚═════╝", "╚═╝    ", "╚═════╝", "╚═╝ ╚═╝", "╚═══╝", "╚════╝", "╚═╝ ╚═╝", "╚═════╝", "╚═╝  ╚══╝  ╚═╝", "╚═╝  ╚══╝", "╚═════╝", "╚═╝    ", "╚══════╝", "╚═╝╚══╝", "╚════╝", "  ╚═╝  ", "╚═════╝", "  ╚══╝  ", " ╚══╝    ╚══╝ ", "╚══╝╚══╝", "   ╚═╝   ", "╚═════╝" };
            string word;
            string path = @"BigText_Output.txt";
            Console.WriteLine("╔════╗ ╔═══╗╔═════╗   ╔═══════╗╔═════╗╔══╗╔══╗╔═══════╗\n║ ╔╗ ║ ╚╗ ╔╝║ ╔═╗ ║   ║ ╔╗ ╔╗ ║║ ╔═══╝╚╗ ╚╝ ╔╝║ ╔╗ ╔╗ ║\n║ ╚╝ ╚╗ ║ ║ ║ ║ ╚═╝   ╚═╝║ ║╚═╝║ ╚══╗  ╚╗  ╔╝ ╚═╝║ ║╚═╝\n║ ╔═╗ ║ ║ ║ ║ ║╔══╗      ║ ║   ║ ╔══╝  ╔╝  ╚╗    ║ ║   \n║ ╚═╝ ║╔╝ ╚╗║ ╚╝  ║      ║ ║   ║ ╚═══╗╔╝ ╔╗ ╚╗   ║ ║   \n╚═════╝╚═══╝╚═════╝      ╚═╝   ╚═════╝╚══╝╚══╝   ╚═╝   \nEnter text below:");
            word = Console.ReadLine();
            Console.WriteLine("Text length = " + Convert.ToString(word.Length));
            File.WriteAllText(path, String.Empty);
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 65;
                File.AppendAllText(path, line1[number]);
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 65;
                File.AppendAllText(path, line2[number]);
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 65;
                File.AppendAllText(path, line3[number]);
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 65;
                File.AppendAllText(path, line4[number]);
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 65;
                File.AppendAllText(path, line5[number]);
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 65;
                File.AppendAllText(path, line6[number]);
            }
            File.AppendAllText(path, "\n");
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText + "\nText file 'BigText_Output.txt' created. \nPress any key to exit...");
            Console.ReadKey();
        }
    }
}