﻿using System;

namespace c_sharp_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.FirstName = "Sabbir";
            person.LastName = "Rahman";

            Console.WriteLine("What do you think the name is?");
            string fullNameGuess = Console.ReadLine();

            if(person.GetFullName() == fullNameGuess)
            {
                Console.WriteLine("You got the name");
            } else
            {
                Console.WriteLine("Try again");
            }
        }

    }
}
