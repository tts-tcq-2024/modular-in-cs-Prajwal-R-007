using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class ColorToPairNumberViceVersaTests
    {
        public static void RunTests()
        {
            ColorFromPairNumberTest(4, Color.White, Color.Brown);
            ColorFromPairNumberTest(5, Color.White, Color.SlateGray);
            ColorFromPairNumberTest(23, Color.Violet, Color.Green);

            PairNumberFromColorTest(Color.Yellow, Color.Green, 18);
            PairNumberFromColorTest(Color.Red, Color.Blue, 6);

            InvalidColorFromPairNumberTest(0);
            InvalidColorFromPairNumberTest(26);

            InvalidPairNumberFromColorTest(Color.Pink,Color.Blue);
            InvalidPairNumberFromColorTest(Color.White,Color.Purple);

        }

        private static void ColorFromPairNumberTest(int pairNumber, Color expectedMajor, Color expectedMinor)
        {
            MajorMinorColorPair colorPair = ColorCoder.GetColorFromPairNumber(pairNumber);
            Debug.Assert(colorPair.MajorColor == expectedMajor);
            Debug.Assert(colorPair.MinorColor == expectedMinor);
        }

        private static void PairNumberFromColorTest(Color majorColor, Color minorColor, int expectedPairNumber)
        {
            MajorMinorColorPair colorPair = new(majorColor, minorColor);
            int pairNumber = ColorCoder.GetPairNumberFromColor(colorPair);
            Debug.Assert(pairNumber == expectedPairNumber);
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
