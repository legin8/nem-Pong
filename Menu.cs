using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pong_NEM
{
    public class Menu
    {
        private const string MENUTEXT = "Press Esc Pause/Menu", NEWGAMETEXT = "Press N for a New Game", RESTARTGAMETEXT = "Press R to Restart",
            RESUMETEXT = "Press Esc To Resume";
        private Font font1;

        public string GetMenuText => MENUTEXT;
        public Font GetFont => font1;
        public Menu()
        {
            font1 = new Font("Ariel", 14, FontStyle.Bold);
        }

    }
}
