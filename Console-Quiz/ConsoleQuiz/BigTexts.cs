﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ConsoleQuiz
{
    public class BigTexts
    {
        public static string[] mainMenuText =
            {
                 "              ███╗░░░███╗░█████╗░██╗███╗░░██╗  ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗",
                 "              ████╗░████║██╔══██╗██║████╗░██║  ████╗░████║██╔════╝████╗░██║██║░░░██║",
                 "              ██╔████╔██║███████║██║██╔██╗██║  ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║",
                 "              ██║╚██╔╝██║██╔══██║██║██║╚████║  ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║",
                 "              ██║░╚═╝░██║██║░░██║██║██║░╚███║  ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝",
                 "              ╚═╝░░░░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝  ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░",
            };

        public static string[] wrongAnswer =
        {

               "                                    ░██╗░░░░░░░██╗██████╗░░█████╗░███╗░░██╗░██████╗░",
               "                                    ░██║░░██╗░░██║██╔══██╗██╔══██╗████╗░██║██╔════╝░",
               "                                    ░╚██╗████╗██╔╝██████╔╝██║░░██║██╔██╗██║██║░░██╗░",
               "                                    ░░████╔═████║░██╔══██╗██║░░██║██║╚████║██║░░╚██╗",
               "                                    ░░╚██╔╝░╚██╔╝░██║░░██║╚█████╔╝██║░╚███║╚██████╔╝",
               "                                    ░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝░╚════╝░╚═╝░░╚══╝░╚═════╝░",
           "                                                                            ",
           "                                ░█████╗░███╗░░██╗░██████╗░██╗░░░░░░░██╗███████╗██████╗░ ",
           "                                ██╔══██╗████╗░██║██╔════╝░██║░░██╗░░██║██╔════╝██╔══██╗ ",
           "                                ███████║██╔██╗██║╚█████╗░░╚██╗████╗██╔╝█████╗░░██████╔╝ ",
           "                                ██╔══██║██║╚████║░╚═══██╗░░████╔═████║░██╔══╝░░██╔══██╗ ",
           "                                ██║░░██║██║░╚███║██████╔╝░░╚██╔╝░╚██╔╝░███████╗██║░░██║ ",
           "                                ╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░░░╚═╝░░░╚═╝░░╚══════╝╚═╝░░╚═╝"
        };

        public static string[] correctAnswer =
        {

            "                               ░█████╗░░█████╗░██████╗░██████╗░███████╗░█████╗░████████╗",
            "                               ██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗╚══██╔══╝",
            "                               ██║░░╚═╝██║░░██║██████╔╝██████╔╝█████╗░░██║░░╚═╝░░░██║░░░",
            "                               ██║░░██╗██║░░██║██╔══██╗██╔══██╗██╔══╝░░██║░░██╗░░░██║░░░",
            "                               ╚█████╔╝╚█████╔╝██║░░██║██║░░██║███████╗╚█████╔╝░░░██║░░░",
            "                               ░╚════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝░╚════╝░░░░╚═╝░░░",
            "                                                                                        ",
            "                                ░█████╗░███╗░░██╗░██████╗░██╗░░░░░░░██╗███████╗██████╗░  ",
            "                                ██╔══██╗████╗░██║██╔════╝░██║░░██╗░░██║██╔════╝██╔══██╗  ",
            "                                ███████║██╔██╗██║╚█████╗░░╚██╗████╗██╔╝█████╗░░██████╔╝  ",
            "                                ██╔══██║██║╚████║░╚═══██╗░░████╔═████║░██╔══╝░░██╔══██╗  ",
            "                                ██║░░██║██║░╚███║██████╔╝░░╚██╔╝░╚██╔╝░███████╗██║░░██║ " ,
            "                                ╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░░░╚═╝░░░╚═╝░░╚══════╝╚═╝░░╚═╝"
        };

        public void WrongAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('\n', 6));
            foreach (string item in wrongAnswer)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();
        }

        public void CorrectAnswer()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(new string('\n', 6));
            foreach (string item in correctAnswer)
            {
                Console.WriteLine(item);
            }
            Console.ResetColor();
        }
    }
}