namespace NumberToTextConverter.Test
{
    public class BillionTest
    {
        
        [Fact]
        public void BillionAndMillionAndHundred_Return_Valid_Text()
        {
            var number = 28_001_000_501m;
            var converter = new NumberConverter(number);
            Assert.Equal("Twenty-Eight Billion One Million Five Hundred and One Dollars",converter.ToString());
        }
        
       
        [Fact]
        public void BillionAndMillionAndThousandAndHundred_Return_Valid()
        {
            var number = 28_001_010_501m;
            var converter = new NumberConverter(number);
            Assert.Equal("Twenty-Eight Billion One Million Teen Thousand Five Hundred and One Dollars",converter.ToString());
        }


        
        [Fact]
        public void BillionAndMillionAndThousandAndHundredsWithCent_Return_Valid()
        {
            var number = 28_001_010_501.3m;
            var number2 = 428_001_010_501.250m;
            
            var converter = new NumberConverter(number);
            var converter2 = new NumberConverter(number2);
            
            Assert.Equal("Twenty-Eight Billion One Million Teen Thousand Five Hundred and One Dollars and Thirty Cents",converter.ToString());
            Assert.Equal("Four Hundred and Twenty-Eight Billion One Million Teen Thousand Five Hundred and One Dollars and Twenty-Five Cents",converter2.ToString());
        }
    }
}