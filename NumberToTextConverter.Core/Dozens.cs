using NumberToTextConverter.Core.Helper;
using NumberToTextConverter.Core.Interface;

namespace NumberToTextConverter.Core;

internal class Dozens : INumberConverterTopDown
{
    // Private properties
    private readonly IDictionary<string, string> NumberStringDictionary = new Dictionary<string, string>()
    {
        { "10", "Teen" },
        { "11", "Eleven" },
        { "12", "Twelve" },
        { "13", "Thirteen" },
        { "14", "Fourteen" },
        { "15", "Fifteen" },
        { "16", "Sixteen" },
        { "17", "Seventeen" },
        { "18", "Eighteen" },
        { "19", "Nineteen" }
    };
    
    private readonly IDictionary<string, string> DozensPrefix = new Dictionary<string, string>()
    { 
        { "2", "Twenty" },
        { "3", "Thirty" },
        { "4", "Forty" },
        { "5", "Fifty" },
        { "6", "Sixty" },
        { "7", "Seventy" },
        { "8", "Eighty" },
        { "9", "Ninety" }
    };
    
    private readonly int _dozenNumber;
    
    
    public INumberConverterTopDown? LowerLevel { get; private set; }
    
    
    // Constructor
    public Dozens(double number)
    {
        _dozenNumber =  Convert.ToInt16(number.GetDozenNumbersString() ?? "0");
        LowerLevel = new Basics(number);
    }
    
    
    
    public override string ToString()
    {
        var lowerLevelString = LowerLevel!.ToString();
        
        if(_dozenNumber == 0)
            return lowerLevelString?? string.Empty;
        
        return GenerateDozenNumberString();

    }

    private string GenerateDozenNumberString()
    {
        var prefixKey = _dozenNumber.ToString().Substring(0, 1);
        if (!DozensPrefix.TryGetValue(prefixKey, out var value))
        {
            return string.Empty;
        }

        if (_dozenNumber % 10 == 0)
            return value;

        var basicConverter = new Basics(Convert.ToInt16(_dozenNumber.ToString().Substring(1, 1)));

        return $"{value}-{basicConverter}";
    }
    
}