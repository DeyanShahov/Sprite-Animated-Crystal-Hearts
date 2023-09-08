namespace Sprite_Animated_Crystal_Hearts
{
    public partial class Form1 : Form
    {
        private readonly List<Image> heartFramesList = new List<Image>();
        Random rand = new Random();
        List<Heart> hearts = new List<Heart>();

        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void SetUp()
        {
            foreach (string frame in ImageFactory.Images)
            {
                Image tempFrame = Image.FromFile(frame);
                heartFramesList.Add(tempFrame);
            }

            this.BackgroundImage = ImageFactory.Background;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            for (int i = 0; i < 20; i++)
            {
                int startFrame = rand.Next(0, heartFramesList.Count);
                Heart newHeart = new Heart(heartFramesList[startFrame], startFrame);
                newHeart.PositionX = rand.Next(10, this.ClientSize.Width - 100);
                newHeart.PositionY = this.ClientSize.Height + rand.Next(300, 1200);
                hearts.Add(newHeart);
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {
            foreach (Heart newHeart in hearts)
            {
                newHeart.AnimateHeart(heartFramesList);
                newHeart.PositionY -= newHeart.SpeedY;

                if (newHeart.PositionY < -100)
                {
                    newHeart.PositionX = rand.Next(10, this.ClientSize.Width - 100);
                    newHeart.PositionY = this.ClientSize.Height + rand.Next(200, 500);
                }
            }

            this.Invalidate();
        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {
            Graphics Canvas = e.Graphics;

            foreach (Heart newHeart in hearts)
            {
                Canvas.DrawImage(newHeart.heart, newHeart.PositionX,
                           newHeart.PositionY, newHeart.Width, newHeart.Height);
            }
        }
    }
}