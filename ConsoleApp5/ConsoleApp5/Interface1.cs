using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public interface IHomework05
    {
        string DisplayLEDOnScreen(string ledNo);
        string LoadState();
        void SaveCurrentState();
        void SetAppConfigurations(string onSymbol, string offSymbol, int spacing);
    }
}
