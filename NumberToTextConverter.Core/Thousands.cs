using NumberToTextConverter.Core.Helper;
using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

internal class Thousands : INumberConverterTopDown
{
    public INumberConverterTopDown? LowerLevel { get; private set; }
    private readonly int _thousandNumber;
    public Thousands(double number)
    {
        _thousandNumber = Convert.ToInt16(number.GetSecond3NumbersFromRight() ?? "0");
        LowerLevel = new Hundreds(number);
    }
    
    public override string ToString()
    {
        throw new NotImplementedException();
    }

   
}