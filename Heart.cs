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

        public Heart(Image frame)
        {
            heart = frame;
            Height = 85;
            Width = 105;

            SpeedY = rand.Next(2, 9);
        }

        public void AnimateHeart(List<Image> framesList)
        {
            if (frames < 11)
            {
                frames++;
                heart = framesList[frames];
            }
            else
            {
                frames = 0;
            }
        }
    }
}
