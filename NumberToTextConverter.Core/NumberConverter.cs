using System.Numerics;
using NumberToTextConverter.Core.Helper;
using NumberToTextConverter.Core.Interface;
namespace NumberToTextConverter.Core;

public class NumberConverter : INumberConverter
{

    private readonly int _numberAfterComma;
    private readonly BigInteger _numberBeforeComma;
    private readonly decimal _number;
    private string? _text;
    
    public NumberConverter(decimal number)
    {
        if (number < 0 || number > 999_999_999_999_999)
            throw new ArgumentOutOfRangeException(nameof(number));
        
        var stringNumberAfterComma = number.GetNumberAfterComma();
        if (stringNumberAfterComma is not null && stringNumberAfterComma.Length > 2 && Convert.ToInt32(stringNumberAfterComma) % 10 > 0 )
            throw new ArgumentException("Can't handle more than 2 digits after comma");

        var numberBeforeCommaString = number.GetNumberBeforeComma();
        _numberAfterComma = Convert.ToUInt16(stringNumberAfterComma?.Substring(0, (stringNumberAfterComma.Length >= 2 ? 2 : 1))?? "0");
        _numberAfterComma = stringNumberAfterComma?.Length == 1 ? _numberAfterComma * 10 : _numberAfterComma;
        _numberBeforeComma = Convert.ToInt64(numberBeforeCommaString);
        _number = number;
    }

    public override string ToString()
    {
        return 
            GenerateTextOfTrillionLevel()
            .GenerateTextOfBillionLevel()
            .GenerateTextOfMillionLevel()
            .GenerateTextOfThousandLevel()
            .GenerateTextOfHundredDozenAndBasicLevel()
            .AddDollarWord()
            .GenerateTextOfCentLevel()
            ._text??string.Empty;
    }

    private string? Space => _text is null ? null : " ";


    private NumberConverter AddDollarWord()
    {
        if (_text is not null)
            _text = $"{_text} Dollar{(_numberBeforeComma > 1 ? "s" : null)}";
        
        return this;
    }
    
    
    private NumberConverter GenerateTextOfCentLevel()
    {
        if (_numberAfterComma == 0)
            return this;
        
        var centText = _numberAfterComma.ConvertThreeDigitToText();
            _text = $"{_text}{(_text is not null? " and " : null)}{centText} Cent{(_numberAfterComma > 1 ? "s" : null)}";
        
        return this;
    }

    private NumberConverter GenerateTextOfHundredDozenAndBasicLevel()
    {
        var hundredNumber = _number.Get3DigitHundredLevel();
        
        if (hundredNumber == 0)
            return this;
        
        var hundredText = hundredNumber.ConvertThreeDigitToText();
        _text = $"{_text}{Space}{hundredText}";

        return this;
    }
    
    
    private NumberConverter GenerateTextOfThousandLevel()
    {
        if (_numberBeforeComma < 1_000)
            return this;
        
        var number = _number.Get3DigitThousandLevel();

        if (number == 0)
            return this;
        
        var text = $"{number.ConvertThreeDigitToText()} Thousand";
        _text = $"{_text}{Space}{text}";

        return this;
    }
    
    private NumberConverter GenerateTextOfMillionLevel()
    {
        if (_numberBeforeComma < 1_000_000)
            return this;
        
        var number = _number.Get3DigitMillionLevel();
        
        if (number == 0)
            return this;
        
        var text =$"{number.ConvertThreeDigitToText()} Million";
        _text = $"{_text}{Space}{text}";

        return this;
    }
    
    private NumberConverter GenerateTextOfBillionLevel()
    {
        if (_numberBeforeComma < 1_000_000_000)
            return this;
        
        var number = _number.Get3DigitBillionLevel();
        if (number == 0)
            return this;
        
        var text = $"{number.ConvertThreeDigitToText()} Billion";
        _text = $"{_text}{Space}{text}";

        return this;
    }
    
    private NumberConverter GenerateTextOfTrillionLevel()
    {
        if (_numberBeforeComma < 1_000_000_000_000)
            return this;
        
        var number = _number.Get3DigitTrillionLevel();
        if (number == 0)
            return this;
        
        var text = $"{number.ConvertThreeDigitToText()} Trillion";
        _text = $"{_text}{Space}{text}";

        return this;
    }
    
}