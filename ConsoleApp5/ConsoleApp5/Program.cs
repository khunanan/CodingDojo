using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i < 10)
            {
                IHomework05 con = new homewark();
                Console.Write("Please choose LED to turn On/Off:");
                String ledNo = Console.ReadLine();
                string sum = con.DisplayLEDOnScreen(ledNo);
                Console.WriteLine(sum);
                Console.WriteLine(" 1  2  3  4  5  6  7  8  9  A");            
            }
        }
    }
}
