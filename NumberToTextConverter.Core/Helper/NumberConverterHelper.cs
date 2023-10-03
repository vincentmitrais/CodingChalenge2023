using System.Globalization;

namespace NumberToTextConverter.Core.Helper;

public static class NumberConverterHelper
{
    private const string FitZero = "000000000000000";
    private static readonly IDictionary<int, string> NumberStringDictionary = new Dictionary<int, string>()
    {
        { 1, "One" },
        { 2, "Two" },
        { 3, "Three" },
        { 4, "Four" },
        { 5, "Five" },
        { 6, "Six" },
        { 7, "Seven" },
        { 8, "Eight" },
        { 9, "Nine" },
        { 10, "Teen" },
        { 11, "Eleven" },
        { 12, "Twelve" },
        { 13, "Thirteen" },
        { 14, "Fourteen" },
        { 15, "Fifteen" },
        { 16, "Sixteen" },
        { 17, "Seventeen" },
        { 18, "Eighteen" },
        { 19, "Nineteen" }
    };
    
    private static readonly IDictionary<int, string> DozensPrefix = new Dictionary<int, string>()
    { 
        { 2, "Twenty" },
        { 3, "Thirty" },
        { 4, "Forty" },
        { 5, "Fifty" },
        { 6, "Sixty" },
        { 7, "Seventy" },
        { 8, "Eighty" },
        { 9, "Ninety" }
    };
    
    // Get the comma separator dynamically base on system settings
    private static string GetCommaSeparator()
    {
        var cultureName = CultureInfo.CurrentCulture.Name;
        NumberFormatInfo numberFormatInfo = new CultureInfo( cultureName, false ).NumberFormat;
        return numberFormatInfo.CurrencyDecimalSeparator;
    }


    public static string GetNumberBeforeComma(this decimal number)
        => $"{FitZero}{number}".Split(GetCommaSeparator())[0];
    
    public static string? GetNumberAfterComma(this decimal number)
    {
        var numbers = $"{number}".Split(GetCommaSeparator());
        if (numbers.Length > 1)
            return numbers[1];

        return null;
    }

    public static int Get3DigitHundredLevel(this decimal number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var threeDigitNumbers =  stringNumber.Substring(stringNumber.Length - 3, 3);
        return Convert.ToInt16(threeDigitNumbers);
    }
    
    
    public static int Get3DigitThousandLevel(this decimal number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var threeDigitNumbers =  stringNumber.Substring(stringNumber.Length - 6, 3);
        return Convert.ToInt16(threeDigitNumbers);
    }
    
    public static int Get3DigitMillionLevel(this decimal number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var threeDigitNumbers =  stringNumber.Substring(stringNumber.Length - 9, 3);
        return Convert.ToInt16(threeDigitNumbers);
    }
    
    public static int Get3DigitBillionLevel(this decimal number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var threeDigitNumbers =  stringNumber.Substring(stringNumber.Length - 12, 3);
        return Convert.ToInt16(threeDigitNumbers);
    }
    
    public static int Get3DigitTrillionLevel(this decimal number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var threeDigitNumbers =  stringNumber.Substring(stringNumber.Length - 15, 3);
        return Convert.ToInt16(threeDigitNumbers);
    }

    

    public static string? ConvertThreeDigitToText(this int number)
    {
        if (number < 0 ||  number > 999)
            throw new ArgumentException(nameof(number));

        if (number == 0)
            return null;
        
        var text = (number % 100).ToBasicString();
        
        var hundredLevel = 0;
        if (number >= 100)
            hundredLevel = Convert.ToInt16(number.ToString().Substring(0, 1));

        if (hundredLevel > 0)
            text = $"{hundredLevel.ToBasicString()} Hundred{(text is null? null : " and ")}{text}";

        return text;
    }
    
    
    private static string? ToBasicString(this int number)
    {
        if (number >= 100 || number < 0)
            throw new ArgumentException(nameof(number));

        if (number == 0)
            return null;

        if (number < 20 && NumberStringDictionary.TryGetValue(number, out var value))
            return value!;

        int dozenLevel = Convert.ToInt16(number.ToString().Substring(0, 1));
        if (DozensPrefix.TryGetValue(dozenLevel, out var prefix) && number % 10 == 0)
            return prefix;

        int singleNumber = Convert.ToInt16(number.ToString().Substring(1, 1));
        NumberStringDictionary.TryGetValue(singleNumber, out var singleValueString);

        return $"{prefix}-{singleValueString}";
    }
}