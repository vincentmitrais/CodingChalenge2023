using System.Numerics;

namespace NumberToTextConverter.Core.Interface;

internal interface INumberConverterTopDown : INumberConverter
{
    public INumberConverterTopDown? LowerLevel { get; }
}