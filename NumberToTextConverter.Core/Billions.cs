using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

internal class Billions : INumberConverterTopDown
{
    private double _number;
    public INumberConverterTopDown? LowerLevel { get; private set; }
    public Billions(double number)
    {
        _number = number;
        LowerLevel = new Millions(number);
    }
    
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}