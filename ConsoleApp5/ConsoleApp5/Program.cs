using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            while (i)
            {
                IHomework05 con = new homewark();
                Console.Write("Please choose LED to turn On/Off:");
                string ledNo = Console.ReadLine();
                if (ledNo == "Exit")
                {
                    i = false;
                }
                else
                {
                    string sum = con.DisplayLEDOnScreen(ledNo);
                    Console.WriteLine($"{sum}");
                    Console.WriteLine(" 1  2  3  4  5  6  7  8  9  A"); 
                }             
            }
        }
    }
}
