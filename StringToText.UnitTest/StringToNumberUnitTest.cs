using StringToNumber;
using System.Threading;

namespace StringToText.UnitTest
{
    public class StringToNumberUnitTest
    {
        [Fact]
        public void WhenGivingTwentyMillions_20000000_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid twenty millions for three such cars.";
            string output = "He paid 20000000 for 3 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void WhenGivingFifityMillions_50000000_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid fifty millions for five such cars.";
            string output = "He paid 50000000 for 5 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void WhenGivingOneMillion_10000000_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid one million for one such cars.";
            string output = "He paid 1000000 for 1 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void WhenGivingOneMillionTen_10000010_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid one million ten for ten such cars.";
            string output = "He paid 1000010 for 10 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void WhenGivingEightMillionTen_80000080_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid eight million eighty for eight such cars.";
            string output = "He paid 8000080 for 8 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void WhenGivingNineMillionTen_90000090_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid nine million ninety for nine such cars.";
            string output = "He paid 9000090 for 9 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

        [Fact]
        public void WhenGivingOneMillionOneThousandOne_10001000_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid one million one thousand one for one such cars.";
            string output = "He paid 1001001 for 1 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }

    }
}