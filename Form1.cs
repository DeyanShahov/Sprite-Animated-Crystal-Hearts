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

            for (int i = 0; i < 50; i++)
            {
                Heart newHeart = new Heart();
                newHeart.PositionX = rand.Next(10, this.ClientSize.Width - 100);
                newHeart.PositionY = this.ClientSize.Height + rand.Next(300, 1200);
                hearts.Add(newHeart);
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }

        private void FormPaintEvent(object sender, PaintEventArgs e)
        {

        }
    }
}