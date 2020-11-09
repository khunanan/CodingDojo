using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public class homewark : IHomework05
    {
        public static string[] led = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        public string DisplayLEDOnScreen(string ledNo)
        {
           
            string sum = null;
            if (ledNo == "A" )
            {
                led[9] = led[9] == "[ ]" ? "[!]" : "[ ]";
            }
            else
            {
                int numled = int.Parse(ledNo);
                numled--;
                led[numled] = led[numled] == "[ ]" ? "[!]" : "[ ]";
            }
            foreach (string item in led)
            {
                sum += item;
            }
            return sum;
        }

        public string LoadState()
        {
            throw new NotImplementedException();
        }

        public void SaveCurrentState()
        {
            throw new NotImplementedException();
        }

        public void SetAppConfigurations(string onSymbol, string offSymbol, int spacing)
        {
            throw new NotImplementedException();
        }
    }
}
