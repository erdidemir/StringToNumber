using StringToNumber;
using System.Threading;

namespace StringToText.UnitTest
{
    public class StringToNumberUnitTest
    {
        [Fact]
        public void WhenGivingTwentyMillion_20000000_ShouldBeReturn()
        {
            TextToNumberService textToNumberService = new TextToNumberService();


            string input = "He paid twenty millions for three such cars.";
            string output = "He paid 20000000 for 3 such cars.";

            var result = textToNumberService.ConvertTextToNumber(input);

            Assert.Equal(output, result);
        }
    }
}