using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrowdSourceApp.Classes;

namespace CrowdSourceApp
{
    public partial class Form1 : Form
    {
        static ServerClientComs SCCC = new ServerClientComs();
        static LiveGames LGC = new LiveGames();        

        public Form1()
        {
            InitializeComponent();
            string result;
            SCCC.UpdateGamesFeed(out result);
            MessageBox.Show(result);
            
            if (System.Diagnostics.Debugger.IsAttached)//If in debugger do this{}
            {
                string[] PH = { "name", "info", "index" };
                SCCC.RequestServerToAddGame(PH);
                
            }
            else
            {
                initTabs();
                
            }
        }

        private void initTabs()
        {
            pageTabControl.Appearance = TabAppearance.FlatButtons;
            pageTabControl.ItemSize = new Size(0, 1);
            pageTabControl.SizeMode = TabSizeMode.Fixed;
        }

    }

}
