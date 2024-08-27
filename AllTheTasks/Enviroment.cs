using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllTheTasks
{
    internal class Enviroment
    {
       private Game game = new Game(1,5);

        public Game Load()
        {
            return game;
        }
    }
}
