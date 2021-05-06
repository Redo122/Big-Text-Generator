﻿using System;
using System.IO;

namespace Big_Text_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line1 = { "   ", "╔═╗", "╔═╗╔═╗", "  ╔═╗ ╔═╗  ", "╔══╔╗══╗", "   ╔═╗   ", " ╔═╔╗══╗", "╔═╗", " ╔═══╗", "╔═══╗ ", "╔═╗ ╔═╗", "       ", "   ", "       ", "   ", "   ╔═╗", "╔═════╗", "╔═══╗  ", "╔════╗ ", "╔═════╗", "╔═╗    ", "╔══════╗", "╔═════╗", "╔═════╗", "╔═════╗", "╔═════╗", "╔═╗", "╔═╗", "  ╔══╗", "       ", "╔══╗  ", "╔═════╗", "╔═══════╗", "╔═════╗", "╔════╗ ", "╔═════╗", "╔═════╗", "╔═════╗", "╔═════╗", "╔═════╗", "╔═╗ ╔═╗", "╔═══╗", "    ╔═╗", "╔═╗ ╔═╗", "╔═╗    ", " ╔══╗    ╔══╗ ", "╔══╗  ╔═╗", "╔═════╗", "╔═════╗", "╔═════╗ ", "╔═════╗", "╔══════╗", "╔═══════╗", "╔═╗ ╔═╗", "╔═╗  ╔═╗", "╔═╗  ╔══╗  ╔═╗", "╔══╗╔══╗", "╔═╗   ╔═╗", "╔═════╗", "╔═══╗", "╔═╗   ", "╔═══╗", " ╔═╗ ", "         ", "╔═╗ ", " ╔═══╗", "╔═╗", "╔═══╗ ", " ╔═╗   " };
            string[] line2 = { "   ", "║ ║", "║ ║║ ║", "╔═╝ ╚═╝ ╚═╗", "║ ╔║║══╝", "╔═╗║ ║   ", "╔╝╔║║══╝", "║ ║", "╔╝ ╔═╝", "╚═╗ ╚╗", "╚╗╚═╝╔╝", "  ╔═╗  ", "   ", "       ", "   ", "  ╔╝ ║", "║ ╔═╗ ║", "╚═╗ ║  ", "╚══╗ ╚╗", "╚═══╗ ║", "║ ║ ╔═╗", "║ ╔════╝", "║ ╔═══╝", "╚═══╗ ║", "║ ╔═╗ ║", "║ ╔═╗ ║", "╚═╝", "╚═╝", " ╔╝ ╔╝", "╔═════╗", "╚╗ ╚╗ ", "║ ╔═╗ ║", "║ ╔═══╗ ║", "║ ╔═╗ ║", "║ ╔╗ ║ ", "║ ╔═══╝", "╚╗ ╔╗ ║", "║ ╔═══╝", "║ ╔═══╝", "║ ╔═╗ ║", "║ ║ ║ ║", "╚╗ ╔╝", "    ║ ║", "║ ║╔╝╔╝", "║ ║    ", "╔╝  ╚╗  ╔╝  ╚╗", "║  ╚╗ ║ ║", "║ ╔═╗ ║", "║ ╔═╗ ║", "║ ╔═╗ ║ ", "║ ╔═╗ ║", "║ ╔════╝", "║ ╔╗ ╔╗ ║", "║ ║ ║ ║", "║ ║  ║ ║", "║ ║ ╔╝  ╚╗ ║ ║", "╚╗ ╚╝ ╔╝", "║ ╚╗ ╔╝ ║", "╚══╗  ║", "║ ╔═╝", "║ ╚╗  ", "╚═╗ ║", "╔╝ ╚╗", "         ", "╚╗╚╗", " ║ ╔═╝", "║ ║", "╚═╗ ║ ", "╔╝ ╚══╗" };
            string[] line3 = { "   ", "║ ║", "╚═╝╚═╝", "╚═╗ ╔═╗ ╔═╝", "║ ╚║║══╗", "╚═╝║ ║   ", "║ ╚║║═╗ ", "╚═╝", "║ ╔╝  ", "  ╚╗ ║", "╔╝╔═╗╚╗", "╔═╝ ╚═╗", "   ", "╔═════╗", "   ", " ╔╝ ╔╝", "║ ║ ║ ║", "  ║ ║  ", "  ╔╝ ╔╝", " ╔══╝ ║", "║ ╚═╝ ║", "║ ╚═══╗ ", "║ ╚═══╗", "    ║ ║", "║ ╚═╝ ║", "║ ╚═╝ ║", "   ", "   ", "╔╝ ╔╝ ", "╚═════╝", " ╚╗ ╚╗", "╚═╝ ║ ║", "║ ║╔══╝ ║", "║ ║ ║ ║", "║ ╚╝ ╚╗", "║ ║    ", " ║ ║║ ║", "║ ╚══╗ ", "║ ╚══╗ ", "║ ║ ╚═╝", "║ ╚═╝ ║", " ║ ║ ", "    ║ ║", "║ ╚╝╔╝ ", "║ ║    ", "║ ╔╗ ╚╗╔╝ ╔╗ ║", "║ ╔╗╚╗║ ║", "║ ║ ║ ║", "║ ╚═╝ ║", "║ ║ ║ ║ ", "║ ╚═╝ ║", "║ ╚════╗", "╚═╝║ ║╚═╝", "║ ║ ║ ║", "║ ╚╗╔╝ ║", "║ ║╔╝ ╔╗ ╚╗║ ║", " ╚╗  ╔╝ ", "╚╗ ╚═╝ ╔╝", "  ╔╝ ╔╝", "║ ║  ", "╚╗ ╚╗ ", "  ║ ║", "╚═══╝", "         ", " ╚═╝", "╔╝ ║  ", "║ ║", "  ║ ╚╗", "╚══╗ ╔╝" };
            string[] line4 = { "   ", "╚═╝", "      ", "╔═╝ ╚═╝ ╚═╗", "╚══║║╗ ║", "   ║ ║╔═╗", "║ ╔║║═╝ ", "   ", "║ ╚╗  ", "  ╔╝ ║", "╚═╝ ╚═╝", "╚═╗ ╔═╝", "╔═╗", "╚═════╝", "   ", "╔╝ ╔╝ ", "║ ║ ║ ║", "  ║ ║  ", " ╔╝ ╔╝ ", " ╚══╗ ║", "╚═══╗ ║", "╚═══╗ ╚╗", "║ ╔═╗ ║", "    ║ ║", "║ ╔═╗ ║", "╚═══╗ ║", "   ", "╔═╗", "╚╗ ╚╗ ", "╔═════╗", " ╔╝ ╔╝", "    ╚═╝", "║ ║╚════╝", "║ ╚═╝ ║", "║ ╔═╗ ║", "║ ║    ", " ║ ║║ ║", "║ ╔══╝ ", "║ ╔══╝ ", "║ ║╔══╗", "║ ╔═╗ ║", " ║ ║ ", "╔═╗ ║ ║", "║ ╔╗╚╗ ", "║ ║    ", "║ ║╚╗ ╚╝ ╔╝║ ║", "║ ║╚╗╚╝ ║", "║ ║ ║ ║", "║ ╔═══╝", "║ ║ ║ ║ ", "║ ╔╗ ╔╝", "╚════╗ ║", "   ║ ║   ", "║ ║ ║ ║", "╚╗ ╚╝ ╔╝", "║ ╚╝ ╔╝╚╗ ╚╝ ║", " ╔╝  ╚╗ ", " ╚═╗ ╔═╝ ", " ╔╝ ╔╝ ", "║ ║  ", " ╚╗ ╚╗", "  ║ ║", "     ", "         ", "    ", "╚╗ ║  ", "║ ║", "  ║ ╔╝", "   ╚═╝ " };
            string[] line5 = { "   ", "╔═╗", "      ", "╚═╗ ╔═╗ ╔═╝", "╔══║║╝ ║", "   ║ ║╚═╝", "╚╗╚║║══╗", "   ", "╚╗ ╚═╗", "╔═╝ ╔╝", "       ", "  ╚═╝  ", "╚╗║", "       ", "╔═╗", "║ ╔╝  ", "║ ╚═╝ ║", "╔═╝ ╚═╗", "╔╝  ╚═╗", "╔═══╝ ║", "    ║ ║", "╔═══╝ ╔╝", "║ ╚═╝ ║", "    ║ ║", "║ ╚═╝ ║", "╔═══╝ ║", "╔═╗", "╚╗║", " ╚╗ ╚╗", "╚═════╝", "╔╝ ╔╝ ", "    ╔═╗", "║ ╚═════╗", "║ ╔═╗ ║", "║ ╚═╝ ║", "║ ╚═══╗", "╔╝ ╚╝ ║", "║ ╚═══╗", "║ ║    ", "║ ╚╝  ║", "║ ║ ║ ║", "╔╝ ╚╗", "║ ╚═╝ ║", "║ ║╚╗╚╗", "║ ╚═══╗", "║ ║ ╚╗  ╔╝ ║ ║", "║ ║ ╚╗  ║", "║ ╚═╝ ║", "║ ║    ", "║ ╚═╝ ╚╗", "║ ║║ ╚╗", "╔════╝ ║", "   ║ ║   ", "║ ╚═╝ ║", " ╚╗  ╔╝ ", "╚╗  ╔╝  ╚╗  ╔╝", "╔╝ ╔╗ ╚╗", "   ║ ║   ", "╔╝  ╚═╗", "║ ╚═╗", "  ╚╗ ║", "╔═╝ ║", "     ", "╔═══════╗", "    ", " ║ ╚═╗", "║ ║", "╔═╝ ║ ", "       " };
            string[] line6 = { "   ", "╚═╝", "      ", "  ╚═╝ ╚═╝  ", "╚══╚╝══╝", "   ╚═╝   ", " ╚═╚╝══╝", "   ", " ╚═══╝", "╚═══╝ ", "       ", "       ", " ╚╝", "       ", "╚═╝", "╚═╝   ", "╚═════╝", "╚═════╝", "╚═════╝", "╚═════╝", "    ╚═╝", "╚═════╝ ", "╚═════╝", "    ╚═╝", "╚═════╝", "╚═════╝", "╚═╝", " ╚╝", "  ╚══╝", "       ", "╚══╝  ", "    ╚═╝", "╚═══════╝", "╚═╝ ╚═╝", "╚═════╝", "╚═════╝", "╚═════╝", "╚═════╝", "╚═╝    ", "╚═════╝", "╚═╝ ╚═╝", "╚═══╝", "╚═════╝", "╚═╝ ╚═╝", "╚═════╝", "╚═╝  ╚══╝  ╚═╝", "╚═╝  ╚══╝", "╚═════╝", "╚═╝    ", "╚══════╝", "╚═╝╚══╝", "╚══════╝", "   ╚═╝   ", "╚═════╝", "  ╚══╝  ", " ╚══╝    ╚══╝ ", "╚══╝╚══╝", "   ╚═╝   ", "╚═════╝", "╚═══╝", "   ╚═╝", "╚═══╝", "     ", "╚═══════╝", "    ", " ╚═══╝", "╚═╝", "╚═══╝ ", "       " };
            string word;
            string path = @"BigText_Output.txt";
            Console.WriteLine("╔════╗ ╔═══╗╔═════╗   ╔═══════╗╔═════╗╔══╗╔══╗╔═══════╗\n" +
                              "║ ╔╗ ║ ╚╗ ╔╝║ ╔═╗ ║   ║ ╔╗ ╔╗ ║║ ╔═══╝╚╗ ╚╝ ╔╝║ ╔╗ ╔╗ ║\n" +
                              "║ ╚╝ ╚╗ ║ ║ ║ ║ ╚═╝   ╚═╝║ ║╚═╝║ ╚══╗  ╚╗  ╔╝ ╚═╝║ ║╚═╝\n" +
                              "║ ╔═╗ ║ ║ ║ ║ ║╔══╗      ║ ║   ║ ╔══╝  ╔╝  ╚╗    ║ ║   \n" +
                              "║ ╚═╝ ║╔╝ ╚╗║ ╚╝  ║      ║ ║   ║ ╚═══╗╔╝ ╔╗ ╚╗   ║ ║   \n" +
                              "╚═════╝╚═══╝╚═════╝      ╚═╝   ╚═════╝╚══╝╚══╝   ╚═╝   \n" +
                              "v1.3\n" +
                              "Enter text below:");
            word = Console.ReadLine();
            Console.WriteLine("Text length = " + Convert.ToString(word.Length));
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 94)
                {
                    Console.WriteLine("Error, this program only supports characters on the standard US QWERTY keyboard.\n" +
                                      "Press any key to exit.");
                    Console.ReadKey();
                }
            }
            File.WriteAllText(path, String.Empty);
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 90)
                {
                    File.AppendAllText(path, line1[number - 26]);
                }
                else
                {
                    File.AppendAllText(path, line1[number]);
                }
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 90)
                {
                    File.AppendAllText(path, line2[number - 26]);
                }
                else
                {
                    File.AppendAllText(path, line2[number]);
                }
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 90)
                {
                    File.AppendAllText(path, line3[number - 26]);
                }
                else
                {
                    File.AppendAllText(path, line3[number]);
                }
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 90)
                {
                    File.AppendAllText(path, line4[number - 26]);
                }
                else
                {
                    File.AppendAllText(path, line4[number]);
                }
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 90)
                {
                    File.AppendAllText(path, line5[number - 26]);
                }
                else
                {
                    File.AppendAllText(path, line5[number]);
                }
            }
            File.AppendAllText(path, "\n");
            for (int i = 0; i < word.Length; i++)
            {
                int number = char.ToUpper(word[i]) - 32;
                if (number > 90)
                {
                    File.AppendAllText(path, line6[number - 26]);
                }
                else
                {
                    File.AppendAllText(path, line6[number]);
                }
            }
            File.AppendAllText(path, "\n");
            string readText = File.ReadAllText(path);
            Console.WriteLine(readText + "\n" +
                             "Text file 'BigText_Output.txt' created. \n" +
                             "Press any key to exit...");
            Console.ReadKey();
        }
    }
}