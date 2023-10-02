using NumberToTextConverter.Core.Interface;
namespace NumberToTextConverter.Core;

internal class Cents : INumberConverterTopDown
{
    private const string CENTS = "Cents";
    private Dozens DozensLevel { get; set; }

    public Cents(int number)
    {
        if (number.ToString().Length > 2)
            throw new ArgumentException("Can't handle more than 2 digits after comma");

        if(number <= 0)
            throw new ArgumentException("Invalid number for cents");
        
        DozensLevel = new Dozens(number);
    }

    public override string ToString() => $"{DozensLevel} {CENTS}";
    
    public INumberConverterTopDown? LowerLevel => DozensLevel.LowerLevel;
}