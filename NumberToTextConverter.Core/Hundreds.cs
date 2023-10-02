using NumberToTextConverter.Core.Helper;
using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

internal class Hundreds : INumberConverterTopDown
{
    public INumberConverterTopDown? LowerLevel { get; }
    private readonly int _hundredNumber;
    private readonly int _hundredLevelNumber;
    
    public Hundreds(double number)
    {
        var threeDigitNumber = number.GetFirst3NumbersFromRight();
        _hundredNumber = Convert.ToInt16(threeDigitNumber ?? "0");
        _hundredLevelNumber = Convert.ToInt16((threeDigitNumber??"0").Substring(0, 1));
        LowerLevel = new Dozens(number);
    }
    
    public override string ToString()
    {
        var lowerLevelStringNumber = LowerLevel?.ToString();
        var hundredNumberString = GenerateHundredString();

        if (hundredNumberString is not null)
            lowerLevelStringNumber = lowerLevelStringNumber is null ? null : $" and {lowerLevelStringNumber}";

        return $"{hundredNumberString}{lowerLevelStringNumber}";
    }
    

    private string? GenerateHundredString()
    {
        string? hundredString = null;

        if (_hundredNumber != 0)
        {
            var basicNumber = new Basics(Convert.ToInt16(_hundredLevelNumber));
            hundredString = $"{basicNumber} Hundred";
        }

        var dozensString = (new Dozens(_hundredNumber % 100)).ToString();
        if (!string.IsNullOrEmpty(dozensString))
            hundredString = $"{hundredString} and {dozensString}";

        return hundredString;

    }
}