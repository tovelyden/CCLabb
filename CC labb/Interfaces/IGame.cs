using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC_labb;

interface IGame
{
    IUI UI { set; }
    string GameName { get; set; }
    int Score { get; set; }

    void PlayGame();
}
