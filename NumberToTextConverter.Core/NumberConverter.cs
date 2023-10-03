﻿using System.Numerics;
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
            GenerateHundredsDozensAndBasics()
            .GenerateThousands()
            .GenerateMillions()
            .GenerateBillions()
            .GenerateTrillion()
            .GenerateCentText()
            ._text??string.Empty;
    }

    private NumberConverter GenerateCentText()
    {
        if (_text is not null)
            _text = $"{_text} Dollar{(_numberBeforeComma > 1 ? "s" : null)}";
            
        var centText = _numberAfterComma.ConvertThreeDigitToText();
        
        if (centText is not null)
            _text = $"{_text}{(_text is not null? " and " : null)}{centText} Cent{(_numberAfterComma > 1 ? "s" : null)}";
        
        return this;
    }

    private NumberConverter GenerateHundredsDozensAndBasics()
    {
        var hundredNumber = _number.Get3DigitHundred();
        var hundredText = hundredNumber.ConvertThreeDigitToText();

        if (hundredText is null)
            return this;
        
        _text = $"{hundredText}{(_text is null ? null : " and ")}{_text}";

        return this;
    }
    
    
    private NumberConverter GenerateThousands()
    {
        var number = _number.Get3DigitThousand();
        var text = number.ConvertThreeDigitToText();

        if (text is not null)
            text = $"{text} Thousand";
        
        if (text is not null)
            _text = $"{text}{(_text is null ? null : " ")}{_text}";

        return this;
    }
    
    private NumberConverter GenerateMillions()
    {
        var number = _number.Get3DigitMillion();
        var text = number.ConvertThreeDigitToText();

        if (text is not null)
            text = $"{text} Million";
        
        if (text is not null)
            _text = $"{text}{(_text is null ? null : " ")}{_text}";

        return this;
    }
    
    private NumberConverter GenerateBillions()
    {  
        var number = _number.Get3DigitBillion();
        var text = number.ConvertThreeDigitToText();

        if (text is not null)
            text = $"{text} Billion";
        
        if (text is not null)
            _text = $"{text}{(_text is null ? null : " ")}{_text}";

        return this;
    }
    
    private NumberConverter GenerateTrillion()
    {
        var number = _number.Get3DigitTrillion();
        var text = number.ConvertThreeDigitToText();

        if (text is not null)
            text = $"{text} Trillion";
        
        if (text is not null)
            _text = $"{text}{(_text is null ? null : " ")}{_text}";

        return this;
    }
    
}