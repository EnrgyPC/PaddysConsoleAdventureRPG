﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PaddysConsoleAdventureRPG;

namespace PaddysConsoleAdventureRPG
{
    public class Character
    {
        public int CurrentHealth { get; set; }
        public int MaximumHealth { get; set; } 
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }

        public int Stamina { get; set; }
        public int AtkPower { get; set; }
        public int DefValue { get; set; }

        public float MaximumCarryWeight { get; set; }
        public float CurrentCarryWeight { get; set; }

        public static string characterName;
        private static bool confirmed = false;
       
        public static void NameCharacter() 
        {
            do
            {
                Story.NPCDialog("Please tell me your name: "); //enter name
                characterName = Console.ReadLine(); //wait for input of name

                ConsoleKey response;
                do
                {
                    Story.NPCDialog("Is the name: " + characterName + " correct?"); //ask if name is correct
                    Console.WriteLine("\n[y/n]\n");//yes or no
                    response = Console.ReadKey(false).Key; //wait for key input
                    if (response != ConsoleKey.Enter) //if response isn't enter key
                    {
                        Console.WriteLine(); //repeat line
                    }
                }
                while (response != ConsoleKey.Y && response != ConsoleKey.N); //repeat code until Y or N is pressed

                confirmed = response == ConsoleKey.Y; //confirmed if response is Y
            }
            while (!confirmed);

            Story.NPCDialog("Nice to meet you " + characterName + "!\n");

            System.Threading.Thread.Sleep(1500); 
        }

    }
}
