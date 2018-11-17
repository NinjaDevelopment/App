using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdSourceApp.Classes
{
    class ServerClientComs
    {
        static Uri address = new Uri("http://localhost:5000/");

        public void UpdateGamesFeed(out string result)
        {            
            using (var web = new System.Net.WebClient())
            result = web.DownloadString(address + "get/;feed");
            
        }

        public void RequestServerToAddGame(string[] gameToAdd)
        {
            string result;
            using (var web = new System.Net.WebClient())
                result = web.DownloadString(address + "add/;" + gameToAdd[0] + "_" + gameToAdd[1] + "_" + gameToAdd[2]);
        }
    }
}
