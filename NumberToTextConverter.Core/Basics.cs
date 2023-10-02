using NumberToTextConverter.Core.Helper;
using NumberToTextConverter.Core.Interface;
namespace NumberToTextConverter.Core;

internal class Basics : INumberConverterTopDown
{
    private readonly IDictionary<int, string> NumberStringDictionary = new Dictionary<int, string>()
    {
        { 1, "One" },
        { 2, "Two" },
        { 3, "Three" },
        { 4, "Four" },
        { 5, "Five" },
        { 6, "Six" },
        { 7, "Seven" },
        { 8, "Eight" },
        { 9, "Nine" }
    };

    public INumberConverterTopDown? LowerLevel { get; }
    private readonly int _basicNumber;

    public Basics(double number)
    {
        _basicNumber = Convert.ToInt16(number.GetBasicNumberString() ?? "0");
        
        var commaSeparator = NumberConverterHelper.GetCommaSeparator();
        var stringNumbers = $"{number}".Split(commaSeparator);
        
        if(stringNumbers.Length == 2)
            LowerLevel = new Cents(Convert.ToInt16(stringNumbers[1]));
    }

    public override string ToString()
    {
        var lowerLevelString = LowerLevel?.ToString();
        
        if (_basicNumber == 0)
            return lowerLevelString??string.Empty;

        var basicNumberString = ConvertBasicNumberToString();
        
        if(basicNumberString is not null)
            lowerLevelString = lowerLevelString is null ? null : $" and {lowerLevelString}";
        
        return $"{ConvertBasicNumberToString()}{lowerLevelString}";
    }

    
    
    string? ConvertBasicNumberToString()
    {
        if (NumberStringDictionary.TryGetValue(_basicNumber, out var value))
        {
            return value!;
        }

        return null;
    }

}