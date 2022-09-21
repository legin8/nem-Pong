using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pong_NEM
{
    public class RandomColor
    {
        private const int COLORRANGE = 256;
        private Random random;

        public Color GetColor() => Color.FromArgb(random.Next(COLORRANGE), random.Next(COLORRANGE), random.Next(COLORRANGE));
        public RandomColor(Random random)
        {
            this.random = random;
        }

        
        

    }
}
