namespace NumberToTextConverter.Test
{
    /// <summary>
    /// This unit test is focusing on limitation of this number converter app
    /// </summary>
    public class BoundaryTest
    {

        [Fact]
        public void NegativeValueTest_ThrowExceptions()
        {
            var number = -20;
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new NumberConverter(number));
        }
        
        [Fact]
        public void NegativeValueWithCentTest_ThrowExceptions()
        {
            var number = -20.50m;
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new NumberConverter(number));
        }
        
        [Fact]
        public void HandleMoreThan2DigitCommas_ThrowExceptions()
        {
            var number = 10.001m;
            Exception ex = Assert.Throws<ArgumentException>(() => new NumberConverter(number));
        }
        
        
        [Fact]
        public void ExitMaxValue_ThrowExceptions()
        {
            var number = 9_999_999_999_999_999;
            Exception ex = Assert.Throws<ArgumentOutOfRangeException>(() => new NumberConverter(number));
        }
        
        
        [Fact]
        public void Zero_Return_EmptyString()
        {
            var number = 0;
            var converter = new NumberConverter(number);
            Assert.Equal(string.Empty, converter.ToString());
        }
        
    }
}