using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class Initializer
    {
        public static void InitializeColorArray(out Color[] colorMapMajor, out Color[] colorMapMinor)
        {
            colorMapMajor = [Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet];
            colorMapMinor = [Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray];
        }
    }
}
