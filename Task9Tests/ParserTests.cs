using Task9;
using FluentAssertions;

namespace Task9Tests;

public class ParserTests
{
    private readonly StringParser _sut;

    public ParserTests()
    {
        _sut = new StringParser();
    }

    #region Value Tests
    
    [Theory]
    [InlineData("42,4", 42.4)]
    [InlineData("42.4", 42.4)]
    [InlineData("0", 0)]
    [InlineData("-42,3", -42.3)]
    [InlineData("-42.3", -42.3)]
    [InlineData(" -42,3 ", -42.3)]
    public void Get_value_from_normal_string(string strOfValue, double valueExpected)
    {
        //Act
        var valueActual = _sut.GetValue(strOfValue);
        
        //Assert
        valueActual.Should().Be(valueExpected);
    }
    
    [Theory]
    [InlineData("42,3a")]
    [InlineData("a42.3")]
    [InlineData("a-")]
    [InlineData(" ")]
    [InlineData(null)]
    public void Get_value_from_invalid_string(string strOfValue)
    {
        //Act
        var act = () => _sut.GetValue(strOfValue);
        
        //Assert
        act.Should().Throw<Exception>();
    }
    
    #endregion

    #region Action tests
    
    [Theory]
    [InlineData("+", StringParser.Action.Plus)]
    [InlineData("-", StringParser.Action.Minus)]
    [InlineData("*", StringParser.Action.Multiply)]
    [InlineData("/", StringParser.Action.Devide)]
    [InlineData(" * ", StringParser.Action.Multiply)]
    public void Get_action_from_normal_string(string strOfAction, StringParser.Action actionExpected)
    {
        //Act
        var actionActual = _sut.GetAction(strOfAction);

        //Assert
        actionActual.Should().Be(actionExpected);
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData("*+")]
    [InlineData("a-")]
    [InlineData(null)]
    public void Get_action_from_invalid_string(string strOfAction)
    {
        //Act
        var act = () => _sut.GetAction(strOfAction);
        
        //Assert
        act.Should().Throw<Exception>();
    }
    
    #endregion
}