using Task9Refactored;
using FluentAssertions;
using Xunit;

namespace Tas9RefactoredTest;

public class CalculatorTests
{
    private readonly Calculator _sut;

    public CalculatorTests()
    {
        _sut = new Calculator();
    }

    [Theory]
    [InlineData("5+3+2*2", 13)]
    [InlineData("4-(3*3)+1", -4)]
    [InlineData("(5+3-2)*3", 18)]
    [InlineData("10/2+3*4", 16)]
    [InlineData("7+8*5-(2*3)+10/2", 36)]
    public void CalculateExpression_WithVariousComplexExpressions(
        string expression, double expectedValue)
    {
        // Arrange

        // Act
        var actualValue = _sut.CalculateExpression(expression);

        // Assert
        actualValue.Should().Be(expectedValue);
    }
}