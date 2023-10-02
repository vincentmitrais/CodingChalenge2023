using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

internal class Millions : INumberConverterTopDown
{
    private double _number;
    public INumberConverterTopDown? LowerLevel { get; private set; }
    public Millions(double number)
    {
        _number = number;
        LowerLevel = new Thousands(number);
    }
    
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}