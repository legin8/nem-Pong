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
        private Font fontMainScreen, fontMenuScreen;

        public string GetMenuText => MENUTEXT;
        public string GetNewGameText => NEWGAMETEXT;
        public string GetRestartGameText => RESTARTGAMETEXT;
        public string GetResumeText => RESUMETEXT;
        public Font GetFontMainScreen => fontMainScreen;
        public Font GetFontMenuScreen => fontMenuScreen;
        public Menu()
        {
            fontMainScreen = new Font("Ariel", 14, FontStyle.Bold);
            fontMenuScreen = new Font("Ariel", 30, FontStyle.Bold);
        }

    }
}
