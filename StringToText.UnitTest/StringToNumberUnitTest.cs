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
    }
}