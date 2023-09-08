namespace Sprite_Animated_Crystal_Hearts
{
    public static class ImageFactory
    {
        private static readonly string assetsPath = Path.Combine(Application.StartupPath)
           .Replace("bin\\Debug\\net6.0-windows\\", "Assets\\");

        public readonly static Image Background = GetImage("bg.jpg");

        public readonly static List<string> Images = GetFilePath("png");


        private static List<string> GetFilePath(string fileType)
        {
            return Directory.GetFiles(assetsPath + $"{fileType}").ToList();
        }

        private static Image GetImage(string file)
        {
            return Image.FromFile(assetsPath + file);
        }
    }
}
