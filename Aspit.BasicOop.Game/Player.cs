using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspit.BasicOop.Game
{
    class Player
    {
        public string name;
        bool isPlayerTurn;
        public int score = 0;


        public Player(string playerName)
        {
            if(playerName.Length >= 6 && playerName.Length <= 16 && char.IsLetter(playerName[0]))
            {
                name = playerName;
            }
            else
            {
                throw new Exception("Ugyldigt spiller navn!!!");
            }
        }
    }
}
