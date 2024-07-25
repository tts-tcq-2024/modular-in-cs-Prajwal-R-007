using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class Initializer
    {
        public static void InitializeColorArray(out Color[] colorMapMajor, out Color[] colorMapMinor)
        {
            colorMapMajor = new Color[] { Color.White, Color.Red, Color.Black, Color.Yellow, Color.Violet };
            colorMapMinor = new Color[] { Color.Blue, Color.Orange, Color.Green, Color.Brown, Color.SlateGray };
        }
    }
}
