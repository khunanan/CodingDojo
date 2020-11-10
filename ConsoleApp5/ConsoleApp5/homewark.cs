using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp5
{
    public class homewark : IHomework05
    {
        public static string[] led = { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]" };
        public string DisplayLEDOnScreen(string ledNo)
        {   
            string sum = null;
            List<string> x = new List<string>
            {
                "1","2","3","4","5","6","7","8","9","A"
            };
            bool check = x.Any(x => ledNo == x);
            if (check == true)
            {
                if (ledNo == "A")
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
            else
            {
                return "Not validation !!";

            }

            
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
