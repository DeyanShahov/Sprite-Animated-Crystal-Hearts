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
        int frameNumber;

        public Heart(Image frame, int frameNumber)
        {
            heart = frame;
            this.frameNumber = frameNumber;
            Height = 85;
            Width = 105;

            SpeedY = rand.Next(2, 9);
        }

        public void AnimateHeart(List<Image> framesList)
        {
            if (frameNumber < 11)
            {
                frameNumber++;
                heart = framesList[frameNumber];
            }
            else
            {
                frameNumber = 0;
            }
        }
    }
}
