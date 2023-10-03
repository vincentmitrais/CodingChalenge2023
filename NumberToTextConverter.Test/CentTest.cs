namespace NumberToTextConverter.Test
{
    public class CentTest
    {
        
        [Fact]
        public void CentOnly_Return_Valid()
        {
            var number = 0.15m;
            var converter = new NumberConverter(number);
            Assert.Equal("Fifteen Cents",converter.ToString());
        }
        
        [Fact]
        public void MoreThan3Digits_Return_Valid()
        {
            var number = 0.150m;
            var converter = new NumberConverter(number);
            Assert.Equal("Fifteen Cents",converter.ToString());
        }
        
        [Fact]
        public void Zero_Return_EmptyString()
        {
            var number = 0.00m;
            var converter = new NumberConverter(number);
            Assert.Equal(string.Empty,converter.ToString());
        }
        
        [Fact]
        public void ZeroCent_Return_ValidText()
        {
            var number = 3.00m;
            var converter = new NumberConverter(number);
            Assert.Equal("Three Dollars",converter.ToString());
        }
    }
}