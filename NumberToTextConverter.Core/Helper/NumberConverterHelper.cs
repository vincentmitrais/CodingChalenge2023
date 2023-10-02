using System.Globalization;

namespace NumberToTextConverter.Core.Helper;

public static class NumberConverterHelper
{
    private const string FitZero = "000000000000000";
    
    // Get the comma separator dynamically base on system settings
    public static string GetCommaSeparator()
    {
        var cultureName = CultureInfo.CurrentCulture.Name;
        NumberFormatInfo numberFormatInfo = new CultureInfo( cultureName, false ).NumberFormat;
        return numberFormatInfo.CurrencyDecimalSeparator;
    }


    public static string GetNumberBeforeComma(this double number)
        => $"{FitZero}{number.ToString("N2").Split(NumberConverterHelper.GetCommaSeparator())[0]}";
    
    public static string GetNumberAfterComma(this double number)
    {
        var numbers = number.ToString("N2").Split(NumberConverterHelper.GetCommaSeparator());
        if (numbers.Length > 1)
            return numbers[1];
        
        return string.Empty;
    }

    public static string? GetBasicNumberString(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var twoDigits =  stringNumber.Substring(stringNumber.Length - 2, 2);
        if (Convert.ToInt16(twoDigits) > 9)
            return null;

        return Convert.ToInt16(twoDigits).ToString();
    }
    
    public static string? GetDozenNumbersString(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        var twoDigits =  stringNumber.Substring(stringNumber.Length - 2, 2);
        if (Convert.ToInt16(twoDigits) > 9)
            return Convert.ToInt16(twoDigits).ToString();
        
        return null;
    }
    
    public static string? GetFirst3NumbersFromRight(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
       return stringNumber.Substring(stringNumber.Length - 3, 3);
    }
    
    public static string? GetSecond3NumbersFromRight(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        return stringNumber.Substring(stringNumber.Length - 6, 3);
    }
    
    public static string? GetThird3NumbersFromRight(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        return stringNumber.Substring(stringNumber.Length - 9, 3);
    }
    
    public static string? GetFourth3NumbersFromRight(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        return stringNumber.Substring(stringNumber.Length - 12, 3);
    }
    
    public static string? GetFifth3NumbersFromRight(this double number)
    {
        var stringNumber = number.GetNumberBeforeComma();
        return stringNumber.Substring(stringNumber.Length - 15, 3);
    }
}