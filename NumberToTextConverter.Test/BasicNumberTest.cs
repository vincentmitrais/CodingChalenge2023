namespace NumberToTextConverter.Test
{
    public class BasicNumberTest
    {
         [Fact]
        public void OneToNine_Valid()
        {
            var number1  = 1;
            var number2  = 2;
            var number3  = 3;
            var number4  = 4;
            var number5  = 5;
            var number6  = 6;
            var number7  = 7;
            var number8  = 8;
            var number9  = 9;
            
            var converter1 = new NumberConverter(number1);
            var converter2 = new NumberConverter(number2);
            var converter3 = new NumberConverter(number3);
            var converter4 = new NumberConverter(number4);
            var converter5 = new NumberConverter(number5);
            var converter6 = new NumberConverter(number6);
            var converter7 = new NumberConverter(number7);
            var converter8 = new NumberConverter(number8);
            var converter9 = new NumberConverter(number9);
            
            Assert.Equal("One Dollar",converter1.ToString());
            Assert.Equal("Two Dollars",converter2.ToString());
            Assert.Equal("Three Dollars",converter3.ToString());
            Assert.Equal("Four Dollars",converter4.ToString());
            Assert.Equal("Five Dollars",converter5.ToString());
            Assert.Equal("Six Dollars",converter6.ToString());
            Assert.Equal("Seven Dollars",converter7.ToString());
            Assert.Equal("Eight Dollars",converter8.ToString());
            Assert.Equal("Nine Dollars",converter9.ToString());
        }
        
        [Fact]
        public void SingularDollar_Valid()
        {
            var number = 1;
            var converter = new NumberConverter(number);
            Assert.Equal("One Dollar",converter.ToString());
        }
        
        [Fact]
        public void SingularDollarWithSingularCent_Valid()
        {
            var number = 1.01m;
            var converter = new NumberConverter(number);
            Assert.Equal("One Dollar and One Cent",converter.ToString());
        }
        
        [Fact]
        public void SingularDollarWithPluralCent_Valid()
        {
            var number = 1.05m;
            var converter = new NumberConverter(number);
            Assert.Equal("One Dollar and Five Cents",converter.ToString());
        }
         
        [Fact]
        public void PluralDollar_Valid()
        {
            var number = 2;
            var converter = new NumberConverter(number);
            Assert.Equal("Two Dollars",converter.ToString());
        }
        
        [Fact]
        public void PluralDollarWithPluralCent_Valid()
        {
            var number = 2.05m;
            var converter = new NumberConverter(number);
            Assert.Equal("Two Dollars and Five Cents",converter.ToString());
        }
        
        [Fact]
        public void PluralDollarWithSingularCent_Valid()
        {
            var number = 2.01m;
            var converter = new NumberConverter(number);
            Assert.Equal("Two Dollars and One Cent",converter.ToString());
        }
        
    }
}