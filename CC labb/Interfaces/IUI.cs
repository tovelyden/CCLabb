using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_labb.Interfaces
{
    interface IUI
    {
        void WriteLine(string s);
        void Write(string s);
        string Read();
        void ExitProgram();
        string ShowResultForRound(int score);
    }
}
