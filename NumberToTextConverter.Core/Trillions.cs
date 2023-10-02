using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

internal class Trillions : INumberConverterTopDown
{
    private double _number;
    public INumberConverterTopDown? LowerLevel { get; private set; }
    
    public Trillions(double number)
    {
        _number = number;
        LowerLevel = new Millions(number);
    }
    
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}