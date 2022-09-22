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
        private const string MENUTEXT = "Press Esc Pause/Menu";
        private Font font;

        public string GetMenuText => MENUTEXT;
        public Font GetFont => font;
        public Menu()
        {
            font = new Font("Ariel", 14, FontStyle.Bold);
        }

    }
}
