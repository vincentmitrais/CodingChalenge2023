namespace NumberToTextConverter.Test
{
    public class MillionTest
    {
        
        [Fact]
        public void MillionAndHundred_Return_Valid()
        {
            var number = 1_000_501;
            var converter = new NumberConverter(number);
            Assert.Equal("One Million Five Hundred and One Dollars",converter.ToString());
        }
        
        [Fact]
        public void MillionAndThousandAndHundred_Return_Valid()
        {
            var number = 1_020_501;
            var converter = new NumberConverter(number);
            Assert.Equal("One Million Twenty Thousand Five Hundred and One Dollars",converter.ToString());
        }
        
        
        [Fact]
        public void HundredMillionAndThousandAndHundredAndCent_Return_Valid()
        {
            var number = 123_020_501.3m;
            var number2 = 123_020_501.250m;
            
            var converter = new NumberConverter(number);
            var converter2 = new NumberConverter(number2);
            
            Assert.Equal("One Hundred and Twenty-Three Million Twenty Thousand Five Hundred and One Dollars and Thirty Cents",converter.ToString());
            Assert.Equal("One Hundred and Twenty-Three Million Twenty Thousand Five Hundred and One Dollars and Twenty-Five Cents",converter2.ToString());
        }
    }
}