using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    public static class Tests
    {
        public static void RunTests()
        {
            ColorFromPairNumberTest(4, Color.White, Color.Brown);
            ColorFromPairNumberTest(5, Color.White, Color.SlateGray);
            ColorFromPairNumberTest(23, Color.Violet, Color.Green);

            PairNumberFromColorTest(Color.Yellow, Color.Green, 18);
            PairNumberFromColorTest(Color.Red, Color.Blue, 6);
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
    }
}
