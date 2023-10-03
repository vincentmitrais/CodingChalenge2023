namespace NumberToTextConverter.Test
{
    public class TrillionTest
    {
        
        [Fact]
        public void TrillionAndBillionAndThousandAndHundreds_Valid()
        {
            var number = 5_328_001_000_501;
            var converter = new NumberConverter(number);
            Assert.Equal("Five Trillion Three Hundred and Twenty-Eight Billion One Million Five Hundred and One Dollars",converter.ToString());
        }
        
       
        [Fact]
        public void HundredTrillionAndBillionAndThousandAndHundreds_Valid()
        {
            var number = 725_328_001_000_501;
            var converter = new NumberConverter(number);
            Assert.Equal("Seven Hundred and Twenty-Five Trillion Three Hundred and Twenty-Eight Billion One Million Five Hundred and One Dollars",converter.ToString());
        }

        
        [Fact]
        public void HundredTrillionAndBillionAndThousandAndHundredsWithCent_Valid()
        {
            var number = 725_328_001_000_501.70m;
            var number2 = 725_328_001_000_501.250m;
            
            var converter = new NumberConverter(number);
            //var converter2 = new NumberConverter(number2);
            
            Assert.Equal("Seven Hundred and Twenty-Five Trillion Three Hundred and Twenty-Eight Billion One Million Five Hundred and One Dollars and Seventy Cents",converter.ToString());
            //Assert.Equal("Seven Hundred and Twenty-Five Trillion Three Hundred and Twenty-Eight Billion One Million Five Hundred and One Dollars and Twenty-Five Cents",converter2.ToString());
            
        }
    }
}