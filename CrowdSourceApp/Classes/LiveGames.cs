using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourceApp.Classes
{
    class LiveGames
    {
        //Varibles
        public List<string[]> liveGamesArray = new List<string[]>();

        public string[] liveGame;
        public string gameName;
        public string gameInfo;
        public int index;

        public void InitVaribles()
        {
            liveGamesArray.Clear();
        }
    }
}
