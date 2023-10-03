namespace NumberToTextConverter.Test
{
    public class ThousandTest
    {
        
        [Fact]
        public void ThousandMixWithHundred_Return_Valid()
        {
            var number = 1501;
            var converter = new NumberConverter(number);
            Assert.Equal("One Thousand Five Hundred and One Dollars",converter.ToString());
        }
        
        
        [Fact]
        public void Thousand_Return_Valid()
        {
            var number = 1000;
            var converter = new NumberConverter(number);
            Assert.Equal("One Thousand Dollars",converter.ToString());
        }
        
        
        [Fact]
        public void ThousandMixWithHundredAnd20Cents_Return_Valid()
        {
            var number = 1501.20m;
            var converter = new NumberConverter(number);
            Assert.Equal("One Thousand Five Hundred and One Dollars and Twenty Cents",converter.ToString());
        }
        
        [Fact]
        public void ThousandMixWithHundredAnd5Cents_Return_Valid()
        {
            var number = 1501.20m;
            var converter = new NumberConverter(number);
            Assert.Equal("One Thousand Five Hundred and One Dollars and Twenty Cents",converter.ToString());
        }
        
        
        [Fact]
        public void ThousandMixWithHundredAndCentOneDigit_Return_Valid()
        {
            var number = 1501.05m;
            var converter = new NumberConverter(number);
            Assert.Equal("One Thousand Five Hundred and One Dollars and Five Cents",converter.ToString());
        }
        
        
        [Fact]
        public void TwoThousand_Return_Valid()
        {
            var number = 2000;
            var converter = new NumberConverter(number);
            Assert.Equal("Two Thousand Dollars",converter.ToString());
        }
        
        
        [Fact]
        public void TwoThousandAndCent_Return_Valid()
        {
            var number = 2000.15m;
            var converter = new NumberConverter(number);
            Assert.Equal("Two Thousand Dollars and Fifteen Cents",converter.ToString());
        }
        
        [Fact]
        public void HundredThousandDollar_Return_Valid()
        {
            var number = 125_345.050m;
            var converter = new NumberConverter(number);
            Assert.Equal("One Hundred and Twenty-Five Thousand Three Hundred and Forty-Five Dollars and Five Cents",converter.ToString());
        }
        
    }
}