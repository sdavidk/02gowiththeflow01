﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2gowiththeflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lamp doesn't work.");
            Console.WriteLine("Is lamp pluged in?");

            string answer = Console.ReadLine();

            if (answer == "yes")
            {
                Console.WriteLine("Is the bulb burned out?");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Replace bulb.");
                }
                else
                {
                    Console.WriteLine("Repair Lamp.");
                }
            }

            else
            {
                Console.WriteLine("Plug in lamp.");
            }




            Console.ReadKey();
        }
    }
}
