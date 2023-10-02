using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

public class NumberConverter : INumberConverter
{
    private double _number;
    private readonly INumberConverterTopDown _topDownConverter;
    
    public NumberConverter(double number)
    {
        _number = number;
        _topDownConverter = new Trillions(number);
    }

    public override string ToString()
    {
        return _topDownConverter.ToString()??"";
    }
}