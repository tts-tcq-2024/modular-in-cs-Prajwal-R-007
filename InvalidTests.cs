using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class InvalidTests
    {
        public static void RunTests()
        {
            InvalidColorFromPairNumberTest(0);
            InvalidColorFromPairNumberTest(26);
            InvalidPairNumberFromColorTest(Color.Pink, Color.Blue);
            InvalidPairNumberFromColorTest(Color.White, Color.Purple);
        }
        private static void InvalidColorFromPairNumberTest(int pairNumber)
        {
            try
            {
                ColorCoder.GetColorFromPairNumber(pairNumber);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Debug.Assert(ex is ArgumentOutOfRangeException);
            }
        }

        private static void InvalidPairNumberFromColorTest(Color majorColor, Color minorColor)
        {
            try
            {
                MajorMinorColorPair colorPair = new(majorColor, minorColor);
                ColorCoder.GetPairNumberFromColor(colorPair);
            }
            catch (ArgumentException ex)
            {
                Debug.Assert(ex is ArgumentException);
            }
        }
    }
}
