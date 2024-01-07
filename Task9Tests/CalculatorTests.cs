using Task9;
using FluentAssertions;

namespace Task9Tests;

public class CalculatorTests
{
    private readonly Calculator _sut;

    public CalculatorTests()
    {
        _sut = new Calculator();
    }

    [Theory]
    [InlineData(1, 2, 3, StringParser.Action.Plus, StringParser.Action.Minus, 0)]
    [InlineData(-1, 2, 3, StringParser.Action.Multiply, StringParser.Action.Minus, -5)]
    [InlineData(6, 3, -1, StringParser.Action.Devide, StringParser.Action.Minus, 3)]
    [InlineData(1, 2, 3, StringParser.Action.Plus, StringParser.Action.Multiply, 7)]
    [InlineData(1, 3, 3, StringParser.Action.Plus, StringParser.Action.Devide, 2)]
    public void Calc_from_normal_values(double value1, double value2, double value3,
        StringParser.Action action1, StringParser.Action action2,
        double valueExpected)
    {
        //Act
        var valueActual = _sut.ThreeValuesCalc(value1, value2, value3, action1, action2);

        //Assert
        valueActual.Should().Be(valueExpected);
    }
}