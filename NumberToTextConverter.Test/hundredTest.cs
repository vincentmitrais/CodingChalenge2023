namespace NumberToTextConverter.Test
{
    public class HundredTest
    {
        
        [Fact]
        public void RandomHundred_Return_Valid()
        {
            var number100  = 100m;
            var number100And5Cent  = 100.05m;
            var number100And25Cent  = 100.25m;
            var number101  = 101;
            var number105  = 105;
            var number225  = 225;
            var number999  = 999;
            
            var converter100 = new NumberConverter(number100);
            var converter100And5Cent = new NumberConverter(number100And5Cent);
            var converter100And25Cent = new NumberConverter(number100And25Cent);
            var converter101 = new NumberConverter(number101);
            var converter105 = new NumberConverter(number105);
            var converter225 = new NumberConverter(number225);
            var converter999 = new NumberConverter(number999);
            
            Assert.Equal("One Hundred Dollars", converter100.ToString());
            Assert.Equal("One Hundred Dollars and Five Cents", converter100And5Cent.ToString());
            Assert.Equal("One Hundred Dollars and Twenty-Five Cents", converter100And25Cent.ToString());
            Assert.Equal("One Hundred and One Dollars", converter101.ToString());
            Assert.Equal("One Hundred and Five Dollars", converter105.ToString());
            Assert.Equal("Two Hundred and Twenty-Five Dollars", converter225.ToString());
            Assert.Equal("Nine Hundred and Ninety-Nine Dollars", converter999.ToString());
        }
        
    }
}