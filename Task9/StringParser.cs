using System.Globalization;

namespace Task9;

public class StringParser
{
    public double GetValue(string? strOfValue)
    {
        if (double.TryParse(strOfValue?.Trim(' '), NumberStyles.Any, new NumberFormatInfo() {  NumberDecimalSeparator = "," }, out var value))
            return value;
        else
            throw new Exception($"Invalid value '{strOfValue}'");
    }

    public Action GetAction(string? strOfAction) => strOfAction.Trim(' ') switch
    {
        "+" => Action.Plus,
        "-" => Action.Minus,
        "*" => Action.Multiply,
        "/" => Action.Devide,
        _ => throw new Exception("Invalid action.")
    };
    
    public enum Action
    {
        Plus,
        Minus,
        Multiply,
        Devide
    }
}