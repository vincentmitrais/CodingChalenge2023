namespace NumberToTextConverter.Test
{
    public class DozenTest
    {
        
        [Fact]
        public void TeenToNineteen_Return_Valid()
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
            var number10 = 10;
            var number11 = 11;
            var number12 = 12;
            var number13 = 13;
            var number14 = 14;
            var number15 = 15;
            var number16 = 16;
            var number17 = 17;
            var number18 = 18;
            var number19 = 19;
            
            
            var converter1 = new NumberConverter(number1);
            var converter2 = new NumberConverter(number2);
            var converter3 = new NumberConverter(number3);
            var converter4 = new NumberConverter(number4);
            var converter5 = new NumberConverter(number5);
            var converter6 = new NumberConverter(number6);
            var converter7 = new NumberConverter(number7);
            var converter8 = new NumberConverter(number8);
            var converter9 = new NumberConverter(number9);
            var converter10 = new NumberConverter(number10);
            var converter11 = new NumberConverter(number11);
            var converter12 = new NumberConverter(number12);
            var converter13 = new NumberConverter(number13);
            var converter14 = new NumberConverter(number14);
            var converter15 = new NumberConverter(number15);
            var converter16 = new NumberConverter(number16);
            var converter17 = new NumberConverter(number17);
            var converter18 = new NumberConverter(number18);
            var converter19 = new NumberConverter(number19);
            
            
            Assert.Equal("One Dollar",converter1.ToString());
            Assert.Equal("Two Dollars",converter2.ToString());
            Assert.Equal("Three Dollars",converter3.ToString());
            Assert.Equal("Four Dollars",converter4.ToString());
            Assert.Equal("Five Dollars",converter5.ToString());
            Assert.Equal("Six Dollars",converter6.ToString());
            Assert.Equal("Seven Dollars",converter7.ToString());
            Assert.Equal("Eight Dollars",converter8.ToString());
            Assert.Equal("Nine Dollars",converter9.ToString());
            Assert.Equal("Teen Dollars",converter10.ToString());
            Assert.Equal("Eleven Dollars",converter11.ToString());
            Assert.Equal("Twelve Dollars",converter12.ToString());
            Assert.Equal("Thirteen Dollars",converter13.ToString());
            Assert.Equal("Fourteen Dollars",converter14.ToString());
            Assert.Equal("Fifteen Dollars",converter15.ToString());
            Assert.Equal("Sixteen Dollars",converter16.ToString());
            Assert.Equal("Seventeen Dollars",converter17.ToString());
            Assert.Equal("Eighteen Dollars",converter18.ToString());
            Assert.Equal("Nineteen Dollars",converter19.ToString());
        }
        
        [Fact]
        public void MultipleOfTeens_Return_Valid()
        {
            var number10  = 10;
            var number20  = 20;
            var number30  = 30;
            var number40  = 40;
            var number50  = 50;
            var number60  = 60;
            var number70  = 70;
            var number80  = 80;
            var number90  = 90;
            var number100 = 100;
            
            
            var converter10 = new NumberConverter(number10);
            var converter20 = new NumberConverter(number20);
            var converter30 = new NumberConverter(number30);
            var converter40 = new NumberConverter(number40);
            var converter50 = new NumberConverter(number50);
            var converter60 = new NumberConverter(number60);
            var converter70 = new NumberConverter(number70);
            var converter80 = new NumberConverter(number80);
            var converter90 = new NumberConverter(number90);
            var converter100 = new NumberConverter(number100);
            
            
            Assert.Equal("Teen Dollars",converter10.ToString());
            Assert.Equal("Twenty Dollars",converter20.ToString());
            Assert.Equal("Thirty Dollars",converter30.ToString());
            Assert.Equal("Forty Dollars",converter40.ToString());
            Assert.Equal("Fifty Dollars",converter50.ToString());
            Assert.Equal("Sixty Dollars",converter60.ToString());
            Assert.Equal("Seventy Dollars",converter70.ToString());
            Assert.Equal("Eighty Dollars",converter80.ToString());
            Assert.Equal("Ninety Dollars",converter90.ToString());
            Assert.Equal("One Hundred Dollars",converter100.ToString());
        }
        
        [Fact]
        public void Random_Return_Valid()
        {
            var number21  = 21;
            var number32  = 32;
            var number43  = 43;
            var number55  = 55;
            var number68  = 68;
            var number74  = 74;
            var number89  = 89;
            var number96  = 96;
            var number77  = 77;
            
            var converter21 = new NumberConverter(number21);
            var converter32 = new NumberConverter(number32);
            var converter43 = new NumberConverter(number43);
            var converter55 = new NumberConverter(number55);
            var converter68 = new NumberConverter(number68);
            var converter74 = new NumberConverter(number74);
            var converter89 = new NumberConverter(number89);
            var converter96 = new NumberConverter(number96);
            var converter77 = new NumberConverter(number77);
            
            Assert.Equal("Twenty-One Dollars",converter21.ToString());
            Assert.Equal("Thirty-Two Dollars",converter32.ToString());
            Assert.Equal("Forty-Three Dollars",converter43.ToString());
            Assert.Equal("Fifty-Five Dollars",converter55.ToString());
            Assert.Equal("Sixty-Eight Dollars",converter68.ToString());
            Assert.Equal("Seventy-Four Dollars",converter74.ToString());
            Assert.Equal("Eighty-Nine Dollars",converter89.ToString());
            Assert.Equal("Ninety-Six Dollars",converter96.ToString());
            Assert.Equal("Seventy-Seven Dollars",converter77.ToString());
        }
        
    }
}