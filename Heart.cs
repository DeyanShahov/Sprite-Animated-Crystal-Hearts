using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite_Animated_Crystal_Hearts
{
    internal class Heart
    {
        public int PositionX;
        public int PositionY;
        public int SpeedY;
        public int Height;
        public int Width;
        public Image heart;

        Random rand = new Random();
        int frames;

        public Heart()
        {
            heart = Image.FromFile("Assets/1.png");
            Height = 85;
            Width = 105;

            SpeedY = rand.Next(2, 9);
        }

        public void AnimateHeart()
        {
            if (frames < 11)
            {
                frames++;
                heart = Image.FromFile("Assets/" + frames + ".png");
            }
            else
            {
                frames = 0;
            }
        }
    }
}
